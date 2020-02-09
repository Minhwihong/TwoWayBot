using System;
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
