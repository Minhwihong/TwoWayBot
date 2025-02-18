﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormSenValAnalyzer.control
{
    class cCal
    {
    }

    

    public struct sIMU6
    {
        public sIMU6(double _accX, double _accY, double _accZ, double _roll, double _pitch, double _yaw)
        {
            Yaw = _yaw;
            Pitch = _pitch;
            Roll = _roll;
            AccX = _accX;
            AccY = _accY;
            AccZ = _accZ;
        }

        public double AccX;
        public double AccY;
        public double AccZ;


        public double Roll;
        public double Pitch;
        public double Yaw;

    }



    public struct sBotPos
    {
        public sBotPos(double _degTheta, double _radTheta, double _degTow, double _radTow)
        {
            degTheta = _degTheta;
            radTheta = _radTheta;
            degTow = _degTow;
            radTow = _radTow;
        }

        double degTheta;
        double radTheta;
        double degTow;
        double radTow;
    }


    class cFilter
    {
        public cFilter()
        {

        }

        private double complBias_Acc = 0.0;
        private double complBias_Gyro = 0.0;



        public bool setBias_inComplementary(double inD1, double inD2)
        {
            double beta;
            double compare = 0.0;
            if (inD1 > inD2)
            {
                beta = (1.0 - inD2);
                compare = Math.Abs(inD1 - beta);
            }
            else if(inD1 < inD2)
            {
                beta = (1.0 - inD1);
                compare = Math.Abs(inD2 - beta);
            }
            else
            {
                compare = Math.Abs(inD2 - inD1);
            }

            if (0.0000001 < compare)
                return false;



            complBias_Acc = inD1;
            complBias_Gyro = inD2;
            return true;
        }

        public double applyComplementary(double inVal)
        {


            return 0.0;
        }

        public double applyKalman(double inVal)
        {
            return 0.0;
        }

    }



    class cPID
    {
        public cPID()
        {
            curr_err = 0.0;
            accum_err = 0.0;
            P_reg = 0.0;
            I_reg = 0.0;
            D_reg = 0.0;
        }

        private double pCurr_err;
        private double pAccum_err;
        private double pP_reg;
        private double pI_reg;
        private double pD_reg;
        private double pTarget;
        private double pSensing;

        public double curr_err { get { return this.pCurr_err; }  set { this.pCurr_err = value; } }
        public double accum_err { get { return this.pAccum_err; }  set { this.pAccum_err = value; } }
        public double P_reg { get { return this.pP_reg; }  set { this.pP_reg = value; } }
        public double I_reg { get { return this.pI_reg; }  set { this.pI_reg = value; } }
        public double D_reg { get { return this.pD_reg; }  set { this.pD_reg = value; } }
        public double Target { get { return this.pTarget; } set { this.pTarget = value; } }
        public double Sensing { get { return this.pSensing; } set { this.pSensing = value; } }

        //public double curr_err { get; set; }
        //public double accum_err { get; set; }
        //public double P_reg { get; set; }
        //public double I_reg { get; set; }
        //public double D_reg { get; set; }
    }



    class cBotPos
    {
        public cBotPos()
        {

        }

        private double deg_theta;

        public double rad_DegTheta(double Xpos, double Ypos)
        {
            return Math.Atan(Xpos / Ypos);
        }

        public double deg_DegTheta(double Xpos, double Ypos)
        {
            return  Math.Atan(Xpos / Ypos)*(180.0 / Math.PI);
        }



        private double rad_theta;

 

    }

   
}
