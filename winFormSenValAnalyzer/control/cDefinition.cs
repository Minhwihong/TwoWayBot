using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormSenValAnalyzer.control
{
    class cDefinition
    {
        

    }

    static public class cSeries
    {
        public const string AccX = "AccX";
        public const string AccY = "AccY";
        public const string AccZ = "AccZ";
        public const string Roll = "Roll";
        public const string Pitch = "Pitch";
        public const string Yaw = "Yaw";

        public const string CurrErr = "Current Error";
        public const string AccumErr = "Accumulated Error";
        public const string TargetValue = "Target Value";
        public const string SensValue = "Sens Value";
    }

    static public class cGrName
    {
        public const string GraphIMU = "IMU-data";
        public const string GraphPID = "PID-data";
    }
}
