using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using winFormSenValAnalyzer.view;
using winFormSenValAnalyzer.control;


using winFormSenValAnalyzer.testing;





namespace winFormSenValAnalyzer
{
    public partial class Form1 : Form, iShareData, iCommData, iTestData
    {
        // ------------ 인터페이스 정의 -------------- // 
        #region Define_Interface
        public DataTable tbMeas { get; set; }
        public int CurrentMode { get; set; }
        

        DataTable iShareData.myData
        {
            get { return this.tbMeas; }
            set { this.tbMeas = value; }
        }

        int iTestData.Mode
        {
            get { return this.CurrentMode; }
            set { this.CurrentMode = value; }
        }

        public UDP_Data commData { get; set; }

        UDP_Data iCommData.commData
        {
            get { return this.commData; }
            set { this.commData = value; }
        }
        #endregion
        // ---------------------------------------- // 



        // (1) UdpClient 객체 성성. 포트 7777 에서 Listening
        protected UdpClient srv;

        // 클라이언트 IP를 담을 변수
        protected IPEndPoint remoteEP;



        Thread thUDPServer;


        cUDPHandle      udpHandle   = new cUDPHandle();
        cGraphControl   grAcc       = new cGraphControl();
        cGraphControl   grGyro      = new cGraphControl();


        int timePassed      = 0;
        
        double maxIMU_val    = 1.0;
        double maxGyroVal   = 1.0;
        double minIMU_val    = -1.0;
        double minGyroVal   = -1.0;
        double deg_normal   = 0.0;
        double initDeg      = 0.0;
        double filteredDeg  = 0.0;

        bool dataLogSts     = false;

        bool PID_start      = false;


   
        DataTable tbMonitor;

        cPID PIDctl;


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            thUDPServer = new Thread(thEPS32_UDP_server);

            // 클라이언트 IP를 담을 변수
            remoteEP    = new IPEndPoint(IPAddress.Any, 0);

            CurrentMode = 0;

            tbInit_tables();
            grInit_graph();

        }


        

       

        

        private void btnServerOpen_Click(object sender, EventArgs e)
        {
            //test mode
            if(CurrentMode == cProgramMode.TEST)
            {
                initTestMode(-10.0, 10.0);
                tmUDPListener.Enabled = true;
                tabBotCtl.Enabled = true;
                grbBotCtl.Enabled = true;
                return;
            }


            // (1) UdpClient 객체 성성. 포트 7777 에서 Listening
            srv = new UdpClient(Convert.ToInt32(txtUDP_PortNum.Text));

            tmUDPListener.Enabled = true;
            tabBotCtl.Enabled = true;

            ThreadState sts = thUDPServer.ThreadState;

            if (sts == ThreadState.Suspended)
            {
                thUDPServer.Resume();
            }
            else
                thUDPServer.Start();

            grbBotCtl.Enabled = true;
        }

        private void btnServerClose_Click(object sender, EventArgs e)
        {
            thUDPServer.Suspend();
   
            tmUDPListener.Enabled = false;
            //srv.Close();
            //srv.Dispose();
        }


        // Convert an object to a byte array
        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //thUDPServer.
            ThreadState sts = thUDPServer.ThreadState;

            if(sts == ThreadState.Suspended)
            {
                srv.Close();
                srv.Dispose();

                thUDPServer.Resume();
                thUDPServer.Abort();     
            }


            tmUDPListener.Enabled = false;

            if(srv != null)
                srv.Dispose();
            
        }



        private void btnSaveAccel_Click(object sender, EventArgs e)
        {
            FileStream fs;
            string path = "dd";
            fs = new FileStream(path,  FileMode.Create);

            StreamWriter sWriter = new StreamWriter(fs, System.Text.Encoding.UTF8);

            sWriter.WriteLine("time(ms),Accel-X,Accel-Y,Accel-Z,Gyro-X,Gyro-Y,Gyro-Z,theta(X-Z)\n");

            for (int idx=0; idx < tbMeas.Rows.Count; ++idx)
            {
                string oneLine = null;
                DataRow writeRow = tbMeas.Rows[idx];
                oneLine = writeRow["time(ms)"].ToString() + "," + writeRow["AccX"].ToString() + "," + writeRow["AccY"].ToString() + "," + writeRow["AccZ"].ToString() + "," +
                    writeRow["GyroX"].ToString() + "," + writeRow["GyroY"].ToString() + "," +  writeRow["GyroZ"].ToString() + "," + writeRow["Theta"].ToString();
                sWriter.WriteLine(oneLine);
            }

            sWriter.Flush();
            sWriter.Close();
            fs.Close();
        }

        private void btnInitSenData_Click(object sender, EventArgs e)
        {
            timePassed = 0;
            chrtAcceleration.Series[0].Points.Clear();
            chrtAcceleration.Series[1].Points.Clear();
            chrtAcceleration.Series[2].Points.Clear();

            chrtGyroscope.Series[0].Points.Clear();
            chrtGyroscope.Series[1].Points.Clear();
            chrtGyroscope.Series[2].Points.Clear();
            tbMeas.Clear();
        }



        private void btnMotorStop_Click(object sender, EventArgs e)
        {
            byte[] payload = { Convert.ToByte(numPWMDuty.Value) };
            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_MT_STOP, payload.Length, payload);
            srv.Send(sendData, sendData.Length, remoteEP);


            filteredDeg = initDeg = 0.0;
        }

        private void btnMotorRev_Click(object sender, EventArgs e)
        {
            byte[] payload = { Convert.ToByte(numPWMDuty.Value) };
            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_MT_SPD, payload.Length, payload);

            srv.Send(sendData, sendData.Length, remoteEP);

            payload[0] = 1;
            sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_MT_REV, payload.Length, payload);

            srv.Send(sendData, sendData.Length, remoteEP);

            initDeg = deg_normal;
            filteredDeg = initDeg;
 
        }

        private void btnMotorForw_Click(object sender, EventArgs e)
        {

            byte[] payload = { Convert.ToByte(numPWMDuty.Value) };
            byte[]  sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_MT_SPD, payload.Length, payload);

            srv.Send(sendData, sendData.Length, remoteEP);

            payload[0] = 0;
            sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_MT_REV, payload.Length, payload);

            srv.Send(sendData, sendData.Length, remoteEP);


            initDeg     = deg_normal;
            filteredDeg = initDeg;

        }

        private void btnLogStart_Click(object sender, EventArgs e)
        {
            if (dataLogSts == false)
            {
                dataLogSts = true;
                btnLogStart.Text = "로깅정지";
            }
            else
            {
                dataLogSts = false;
                btnLogStart.Text = "로깅시작";
            }


            if (CurrentMode == cProgramMode.TEST)
            {
                return;
            }
                
            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_IMU_GET_VALUE);
            srv.Send(sendData, sendData.Length, remoteEP);
        }


        private void btnRefreshGyro_Click(object sender, EventArgs e)
        {
            filteredDeg = deg_normal;
        }

        private void btnPID_start_Click(object sender, EventArgs e)
        {
            int add         = 0;
            byte[] payload  = new byte[1];

            payload[add++]  = 1;
            PID_start       = true;

            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_PID_ONOFF, payload.Length, payload);

            srv.Send(sendData, sendData.Length, remoteEP);
        }

        private void btnPID_reset_Click(object sender, EventArgs e)
        {

            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_PID_RST);

            srv.Send(sendData, sendData.Length, remoteEP);
        }

        private void btnPID_stop_Click(object sender, EventArgs e)
        {
            int add         = 0;
            byte[] payload  = new byte[1];

            payload[add++]  = 0;
            PID_start       = true;

            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_PID_ONOFF, payload.Length, payload);

            srv.Send(sendData, sendData.Length, remoteEP);
        }

        private void btnPID_renew_Click(object sender, EventArgs e)
        {
            byte[] arrKp    = System.BitConverter.GetBytes(Convert.ToDouble(numPID_Kp.Value));
            byte[] arrKi    = System.BitConverter.GetBytes(Convert.ToDouble(numPID_Ki.Value));
            byte[] arrKd    = System.BitConverter.GetBytes(Convert.ToDouble(numPID_Kd.Value));
            byte[] payload  = new byte[arrKp.Length + arrKi.Length + arrKd.Length];

            int add = 0;
            
            for (int idx = 0; idx < sizeof(double); idx++)
                payload[add++] = arrKp[idx];

            for (int idx = 0; idx < sizeof(double); idx++)
                payload[add++] = arrKi[idx];

            for (int idx = 0; idx < sizeof(double); idx++)
                payload[add++] = arrKd[idx];

            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_PID_SET_K_PARAM, payload.Length, payload);

            srv.Send(sendData, sendData.Length, remoteEP);

        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.frmTable fTable = new form.frmTable(this as iShareData);
            fTable.Show();
        }

        private void btnSetTrgAngle_Click(object sender, EventArgs e)
        {
            byte[] trgAngle = System.BitConverter.GetBytes(Convert.ToDouble(numTrgAngle.Value));
            byte[] payload = new byte[trgAngle.Length];

            int add = 0;
            
            for (int idx = 0; idx < sizeof(double); idx++)
                payload[add++] = trgAngle[idx];

            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_PID_SET_TRT_ANGLE, payload.Length, payload);

            srv.Send(sendData, sendData.Length, remoteEP);
        }

        private void testModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.frmTestSetting fTestSetting = new form.frmTestSetting(this as iTestData);
            fTestSetting.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPIDLogging_Click(object sender, EventArgs e)
        {
            if (dataLogSts == false)
            {
                dataLogSts = true;
                btnLogStart.Text = "로깅정지";
            }
            else
            {
                dataLogSts = false;
                btnLogStart.Text = "로깅시작";
            }


            if (CurrentMode == cProgramMode.TEST)
            {
                return;
            }

            byte[] sendData = udpHandle.UDP_sendData(cUDP_CMD.uCMD_PID_GET_PARAM);
            srv.Send(sendData, sendData.Length, remoteEP);
        }

        
    }



 

}
