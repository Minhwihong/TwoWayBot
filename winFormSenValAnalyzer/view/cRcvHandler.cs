using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using winFormSenValAnalyzer.control;



namespace winFormSenValAnalyzer
{
    partial class Form1 : iShareData
    {

        private void thEPS32_UDP_server()
        {
            while (true)
            {

                

                // (2) 데이타 수신
                byte[] dgram = srv.Receive(ref remoteEP);

                if (dgram.Length > 0)
                {
                    udpHandle.UDP_RcvHandle(dgram);
                }

            }
        }


        private void tmUDPListener_Tick(object sender, EventArgs e)
        {

            if (CurrentMode == 1)
            {
                if (dataLogSts)
                {
                    grAcc.addPoint(ref chrtAcceleration, timePassed, new double[] { getRandomValue(), getRandomValue(), getRandomValue() });
                    grAcc.adjust_Yaxis_scale(ref chrtAcceleration, new double[] { getRandomValue(), getRandomValue(), getRandomValue() });

                    grGyro.addPoint(ref chrtGyroscope, timePassed, new double[] { getRandomValue(), getRandomValue(), getRandomValue() });
                    grGyro.adjust_Yaxis_scale(ref chrtGyroscope, new double[] { getRandomValue(), getRandomValue(), getRandomValue() });

                    chrtDegree.Series["DgrNormal"].Points.AddXY(timePassed, deg_normal);
                    chrtDegree.Series["Filtered"].Points.AddXY(timePassed, filteredDeg);
                }
                timePassed = timePassed + 100;
                return;
            }


            UDP_Data rcvPkt = udpHandle.getPacket();
            if (rcvPkt.pkt_cmd != 0)
            {
                switch (rcvPkt.pkt_cmd)
                {
                    case cUDP_CMD.uCMD_IMU_GET_VALUE:

                        sIMU6 sensing_data = ParseIMU6_fromUDP(rcvPkt);
                        tbAdd_6axit_data(timePassed, sensing_data);

                        cBotPos pos = new cBotPos();

                        deg_normal = pos.deg_DegTheta(sensing_data.AccY, sensing_data.AccZ);

                        txtTheta.Text = deg_normal.ToString();

                        if (dataLogSts)
                        {
                            grAcc.addPoint(ref chrtAcceleration, timePassed, new double[] { sensing_data.AccX, sensing_data.AccY, sensing_data.AccZ });
                            grAcc.adjust_Yaxis_scale(ref chrtAcceleration, new double[] { sensing_data.AccX, sensing_data.AccY, sensing_data.AccZ });

                            grGyro.addPoint(ref chrtGyroscope, timePassed, new double[] { sensing_data.Roll, sensing_data.Pitch, sensing_data.Yaw });
                            grGyro.adjust_Yaxis_scale(ref chrtGyroscope, new double[] { sensing_data.Roll, sensing_data.Pitch, sensing_data.Yaw });

                            chrtDegree.Series["DgrNormal"].Points.AddXY(timePassed, deg_normal);
                            chrtDegree.Series["Filtered"].Points.AddXY(timePassed, filteredDeg);
                        }

                        timePassed = timePassed + 100;
                        break;

                    case cUDP_CMD.uCMD_PID_GET_PARAM:
                        break;
                }


            }


        }


    }
}
