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
                    grAcc.addPoint(ref chrtAcceleration, timePassed, new double[] { getRandomValue(), 1.5 + getRandomValue(), 2.5 + getRandomValue(), -1.0 + getRandomValue(), -1.5 + getRandomValue(), -2.5 + getRandomValue() });
                    grAcc.adjust_Yaxis_scale(ref chrtAcceleration, new double[] { getRandomValue(), 1.5 + getRandomValue(), 2.5 + getRandomValue(), -1.0 + getRandomValue(), -1.5 + getRandomValue(), -2.5 + getRandomValue() });

                    grGyro.addPoint(ref chrtGyroscope, timePassed, new double[] { getRandomValue(), getRandomValue(), getRandomValue() });
                    grGyro.adjust_Yaxis_scale(ref chrtGyroscope, new double[] { getRandomValue(), getRandomValue(), getRandomValue() });

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
                            grAcc.addPoint(ref chrtAcceleration, timePassed, new double[] { sensing_data.AccX, sensing_data.AccY, sensing_data.AccZ, sensing_data.Roll, sensing_data.Pitch, sensing_data.Yaw });
                            grAcc.adjust_Yaxis_scale(ref chrtAcceleration, new double[] { sensing_data.AccX, sensing_data.AccY, sensing_data.AccZ, sensing_data.Roll, sensing_data.Pitch, sensing_data.Yaw });
                        }

                        timePassed = timePassed + 100;
                        break;

                    case cUDP_CMD.uCMD_PID_GET_PARAM:
                        int offset = 0;
                        double dVal = 0.0;
                        cPID PIDctl = new cPID();

                        dVal = BitConverter.ToDouble(rcvPkt.payload, offset);
                        offset += sizeof(double);
                        PIDctl.curr_err = dVal;
                        
                        dVal = BitConverter.ToDouble(rcvPkt.payload, offset);
                        offset += sizeof(double);
                        PIDctl.accum_err = dVal;
                        
                        dVal = BitConverter.ToDouble(rcvPkt.payload, offset);
                        offset += sizeof(double);
                        PIDctl.P_reg = dVal;
                        
                        dVal = BitConverter.ToDouble(rcvPkt.payload, offset);
                        offset += sizeof(double);
                        PIDctl.I_reg = dVal;
                        
                        dVal = BitConverter.ToDouble(rcvPkt.payload, offset);
                        offset += sizeof(double);
                        PIDctl.D_reg = dVal;


                        grGyro.addPoint(ref chrtGyroscope, timePassed, new double[] { PIDctl.curr_err, PIDctl.accum_err, PIDctl.curr_err, PIDctl.accum_err });
                        grGyro.adjust_Yaxis_scale(ref chrtGyroscope, new double[] { PIDctl.curr_err, PIDctl.accum_err, PIDctl.curr_err, PIDctl.accum_err });


                        txtPID_err.Text = string.Format("{0:0.0000}", PIDctl.curr_err);
                        txtPID_accumErr.Text = string.Format("{0:0.0000}", PIDctl.accum_err);
                        txtPID_Preg.Text = string.Format("{0:0.0000}", PIDctl.P_reg);
                        txtPID_Ireg.Text = string.Format("{0:0.0000}", PIDctl.I_reg);
                        txtPID_Dreg.Text = string.Format("{0:0.0000}", PIDctl.D_reg);
                        txtPID_val.Text = string.Format("{0:0.0000}", PIDctl.P_reg + PIDctl.D_reg + PIDctl.D_reg);
                        break;
                }


            }


        }


        

        private sIMU6 ParseIMU6_fromUDP(UDP_Data inData)
        {
            sIMU6 sensing_data;

            int offset = 0;
            sensing_data.AccX = BitConverter.ToSingle(inData.payload, offset);
            offset += 4;
            sensing_data.AccY = BitConverter.ToSingle(inData.payload, offset);
            offset += 4;
            sensing_data.AccZ = BitConverter.ToSingle(inData.payload, offset);
            offset += 4;
            sensing_data.Roll = BitConverter.ToSingle(inData.payload, offset);
            offset += 4;
            sensing_data.Pitch = BitConverter.ToSingle(inData.payload, offset);
            offset += 4;
            sensing_data.Yaw = BitConverter.ToSingle(inData.payload, offset);
            offset += 4;

            return sensing_data;

        }


    }
}
