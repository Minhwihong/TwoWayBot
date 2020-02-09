using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace winFormSenValAnalyzer.control
{

    public enum Rcv_State
    {
        eWAIT_FRM_ID = 0,
        eGET_FRM_ID,
        eWAIT_FRM_IDX,
        eWAIT_PKT_ID,
        eWAIT_PKT_CMD,
        eWAIT_PKT_LENG,
        eONGOING_DATA,
        eGET_PKT_DATA,
        eWAIT_CS,
        ePKT_ERR
    }


    public struct UDP_Data
    {
        public byte frm_Id;
        public byte frm_Idx;
        public byte pkt_Id;
        public byte pkt_cmd;
        public byte pkt_leng;
        public byte[] payload;
        public byte pkt_cs;
        public bool pkt_OK;
    }






    class cUDPHandle : iCommData
    {
        public cUDPHandle()
        {
            idxData = 0;
            UDP_initRcvParam();
            qPacket = new Queue<UDP_Data>();
        }

        public UDP_Data commData { get; set; }

        UDP_Data iCommData.commData
        {
            get { return this.commData; }
            set { this.commData = value; }
        }



        private Rcv_State sts = Rcv_State.eWAIT_FRM_ID;
        private byte frameID;
        private byte frameIdx;
        private byte pktID;
        private byte pktCmd;
        private int pktleng;
        private byte pktCS;
        private byte[] arrPktData;
        private int idxData;




        private Queue<UDP_Data> qPacket;


        private void initQueue()
        {
            qPacket.Clear();
        }


        private byte CS_Calculation(byte[] inB, int leng)
        {
            UInt16 ret = 0;

            for(int idx=0; idx < leng; ++ idx)
            {
                ret += (UInt16)inB[idx];

                if (ret > 0xFF)
                    ret -= 0xFF;
            }


            return (byte)ret;
        }



        private void UDP_initRcvParam()
        {
            frameID     = 0;
            frameIdx    = 0;
            pktID       = 0;
            pktCmd      = 0;
            pktleng     = 0;
            pktCS      = 0;
            idxData     = 0;
        }



        private UDP_Data UDP_initData()
        {
            UDP_Data inD;
            inD.frm_Id = 0;
            inD.frm_Idx = 0;
            inD.pkt_cmd = 0;
            inD.pkt_leng = 0;
            inD.payload = new byte[3];
            inD.pkt_cs = 0;
            inD.pkt_Id = 0;
            inD.pkt_OK = false;

            return inD;
        }

        private void UDP_create_pkt(ref UDP_Data inD)
        {
            inD.frm_Id  = frameID;
            inD.frm_Idx = frameIdx;
            inD.pkt_Id  = pktID;
            inD.pkt_cmd = pktCmd;
            inD.pkt_leng = (byte)pktleng;
            inD.payload = new byte[arrPktData.Length];
            arrPktData.CopyTo(inD.payload, 0);
            inD.pkt_cs = pktCS;
            inD.pkt_OK = true;
        }

       


        public void UDP_RcvHandle(byte[] rcvArr)
        {
            UDP_Data ret = UDP_initData();

            int leng    = rcvArr.Length;
            int add     = 0;
            byte u8Val  = 0;


            while(leng != add)
            {
                switch (sts)
                {
                    case Rcv_State.eWAIT_FRM_ID:
                        u8Val = rcvArr[add++]; 
                        switch(u8Val)
                        {
                            case cUDP_CMD.uFRM_ID_NORMAL:
                            case cUDP_CMD.uFRM_ID_DEBUG:
                                UDP_initRcvParam();
                                ret         = UDP_initData();
                                frameID     = u8Val;
                                sts         = Rcv_State.eWAIT_FRM_IDX;
                                break;
                            default:
                                break;
                        }                     
                        break;

                    case Rcv_State.eWAIT_FRM_IDX:
                        u8Val = rcvArr[add++];
                        switch (u8Val)
                        {
                            case cUDP_CMD.uFRM_IDX_NORMAL:
                            case cUDP_CMD.uFRM_IDX_RES1:
                                frameIdx    = u8Val;
                                sts         = Rcv_State.eWAIT_PKT_ID;
                                break;
                            default:
                                sts         = Rcv_State.eWAIT_FRM_ID;
                                break;
                        }
                        break;

                    case Rcv_State.eWAIT_PKT_ID:
                        u8Val       = rcvArr[add++];
                        // filtering packet id
                        pktID       = u8Val;
                        sts         = Rcv_State.eWAIT_PKT_CMD;
                        break;

                    case Rcv_State.eWAIT_PKT_CMD:
                        u8Val       = rcvArr[add++];

                        switch(u8Val)
                        {
                            case cUDP_CMD.uCMD_PID_GET_PARAM:
                            case cUDP_CMD.uCMD_IMU_GET_VALUE:
                            case cUDP_CMD.uCMD_SYS_ARRIVE:
                                pktCmd      = u8Val;
                                sts         = Rcv_State.eWAIT_PKT_LENG;
                                break;
                            default:
                                sts         = Rcv_State.eWAIT_FRM_ID;
                                break;
                        }
                        break;

                    case Rcv_State.eWAIT_PKT_LENG:
                        u8Val       = rcvArr[add++];
                        pktleng     = u8Val;

                        if(pktleng == 0)
                            sts         = Rcv_State.eWAIT_CS;
                        else
                            sts         = Rcv_State.eONGOING_DATA;

                        arrPktData = new byte[pktleng];
                        idxData = 0;
                        break;

                    case Rcv_State.eONGOING_DATA:
                        arrPktData[idxData++] = rcvArr[add++];

                        if(idxData == pktleng)  sts = Rcv_State.eWAIT_CS;
                       
                        break;

                    case Rcv_State.eWAIT_CS:
                        byte cs     = CS_Calculation(rcvArr, pktleng + 5);
                        pktCS       = rcvArr[add++];
                        

                        Console.WriteLine("cs1: " + pktCS + ", cs2: " + cs);
                        if(cs == pktCS)
                        {
                            UDP_create_pkt(ref ret);
                            Console.WriteLine(ret.pkt_cmd);
                            Console.WriteLine(ret.pkt_leng);
                            qPacket.Enqueue(ret);

                            if (qPacket.Count > 100)    initQueue();
  
                        }
                        sts = Rcv_State.eWAIT_FRM_ID;
                        break;

                } // end switch
            } // end while

            
        }


        public UDP_Data getPacket()
        {
            UDP_Data ret;

            if(qPacket.Count != 0)
                ret = qPacket.Dequeue();
            else
                ret = UDP_initData();
            

            return ret;
        }




        public byte[] UDP_sendData(byte cmd, int len, byte[] inB)
        {
            byte sendfrmID = cUDP_CMD.uFRM_ID_NORMAL;
            byte sendfrmIdx = cUDP_CMD.uFRM_IDX_NORMAL;
            byte sendPktID = 0xAB;
            byte sendPktCmd = cmd;
            int sendPktlen = len;
            byte sendPktCS = 0;

            byte[] sendPktData = new byte[len + 6];

            int add = 0;

            sendPktData[add++] = sendfrmID;
            sendPktData[add++] = sendfrmIdx;
            sendPktData[add++] = sendPktID;
            sendPktData[add++] = sendPktCmd;
            sendPktData[add++] = (byte)sendPktlen;

            for (int idx = 0; idx < sendPktlen; ++idx)
                sendPktData[add++]  = inB[idx];

            sendPktCS           = CS_Calculation(sendPktData, add);
            sendPktData[add++] = sendPktCS;


            return sendPktData;
        }

        public byte[] UDP_sendData(byte cmd)
        {
            byte sendfrmID = cUDP_CMD.uFRM_ID_NORMAL;
            byte sendfrmIdx = cUDP_CMD.uFRM_IDX_NORMAL;
            byte sendPktID = 0xAB;
            byte sendPktCmd = cmd;
            int sendPktlen = 0;
            byte sendPktCS = 0;

            byte[] sendPktData = new byte[6];

            int add = 0;

            sendPktData[add++] = sendfrmID;
            sendPktData[add++] = sendfrmIdx;
            sendPktData[add++] = sendPktID;
            sendPktData[add++] = sendPktCmd;
            sendPktData[add++] = (byte)sendPktlen;

            sendPktCS = CS_Calculation(sendPktData, add);
            sendPktData[add++] = sendPktCS;


            return sendPktData;
        }

    }
}
