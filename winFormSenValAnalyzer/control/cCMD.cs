using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormSenValAnalyzer.control
{
    static public class cUDP_CMD
    {
        public const byte uFRM_ID_NORMAL = (byte)'N';
        public const byte uFRM_ID_DEBUG = 0x21;
        public const byte uFRM_ID_RES1  = 0x22;
        public const byte uFRM_ID_RES2  = 0x23;

        public const byte uFRM_IDX_NORMAL = 0x00;
        public const byte uFRM_IDX_RES1 = 0xFF;
        public const byte uFRM_IDX_RES2 = 0xFE;


        //send from PC to fw
        public const byte uCMD_SYS_ARRIVE= 0x05;
        public const byte uCMD_MT_SPD = 0x10;
        public const byte uCMD_MT_STOP = 0x11;
        public const byte uCMD_MT_REV = 0x12;
        public const byte uCMD_PID_ONOFF = 0x14;
        public const byte uCMD_PID_RST = 0x15;
        public const byte uCMD_PID_SET_K_PARAM = 0x16;
        public const byte uCMD_PID_SET_TRT_ANGLE = 0x17;

        //receive from fw
        public const byte uCMD_PID_GET_PARAM = 0x18;
        public const byte uCMD_IMU_GET_VALUE = 0x19;
        //static public byte uCMD_MT_SPD = 0x10;
    }
}
