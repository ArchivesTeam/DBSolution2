using System;
using System.Data;
using System.Data.SqlTypes;
namespace SdlDB.Entity
{
    /// <summary>
    /// sdl_FinishedProductsSaleTitle ��ժҪ˵��
    /// </summary>
    [Serializable()]
    public class Sdl_FinishedProductsSaleTitle
    {
        public Sdl_FinishedProductsSaleTitle()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }


        /// <summary>
        /// 
        /// </summary>
        public string TRUCKNUM
        {
            set
            {
                tRUCKNUM = value;
            }
            get
            {
                return tRUCKNUM;
            }
        }
        private string tRUCKNUM = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public string VBELN
        {
            set
            {
                vBELN = value;
            }
            get
            {
                return vBELN;
            }
        }
        private string vBELN = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public string KUNNR
        {
            set
            {
                kUNNR = value;
            }
            get
            {
                return kUNNR;
            }
        }
        private string kUNNR = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public string NAME1
        {
            set
            {
                nAME1 = value;
            }
            get
            {
                return nAME1;
            }
        }
        private string nAME1 = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public string WEIGHMAN
        {
            set
            {
                wEIGHMAN = value;
            }
            get
            {
                return wEIGHMAN;
            }
        }
        private string wEIGHMAN = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public double TARE
        {
            set
            {
                tARE = value;
            }
            get
            {
                return tARE;
            }
        }
        private double tARE = 0;


        /// <summary>
        /// 
        /// </summary>
        public SqlDateTime ENTERTIME
        {
            set
            {
                eNTERTIME = value;
            }
            get
            {
                return eNTERTIME;
            }
        }
        private SqlDateTime eNTERTIME = SqlDateTime.MinValue;


        /// <summary>
        /// 
        /// </summary>
        public SqlDateTime EXITTIME
        {
            set
            {
                eXITTIME = value;
            }
            get
            {
                return eXITTIME;
            }
        }
        private SqlDateTime eXITTIME = SqlDateTime.MinValue;


        /// <summary>
        /// 
        /// </summary>
        public double GROSS
        {
            set
            {
                gROSS = value;
            }
            get
            {
                return gROSS;
            }
        }
        private double gROSS = 0;


        /// <summary>
        /// 
        /// </summary>
        public string HS_FLAG
        {
            set
            {
                hS_FLAG = value;
            }
            get
            {
                return hS_FLAG;
            }
        }
        private string hS_FLAG = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public string WERKS
        {
            set
            {
                wERKS = value;
            }
            get
            {
                return wERKS;
            }
        }
        private string wERKS = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public string TIMEFLAG
        {
            set
            {
                tIMEFLAG = value;
            }
            get
            {
                return tIMEFLAG;
            }
        }
        private string tIMEFLAG = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string EXITWEIGHMAN
        {
            set
            {
                eXITWEIGHMAN = value;
            }
            get
            {
                return eXITWEIGHMAN;
            }
        }
        private string eXITWEIGHMAN = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public int EXITFLAG
        {
            set
            {
                eXITFLAG = value;
            }
            get
            {
                return eXITFLAG;
            }
        }
        private int eXITFLAG = 0;

        /// <summary>
        /// �ذ����
        /// </summary>
        public string DBNUM
        {
            set
            {
                dBNUM = value;
            }
            get
            {
                return dBNUM;
            }
        }
        private string dBNUM = string.Empty;

        /// <summary>
        /// ��������
        /// </summary>
        public Int16 TRAYQUANTITY
        {
            set
            {
                tRAYQUANTITY = value;
            }
            get
            {
                return tRAYQUANTITY;
            }
        }
        private Int16 tRAYQUANTITY = 0;
       
        /// <summary>
        /// ��������
        /// </summary>
        public Int16 TRAYWEIGHT
        {
            set
            {
                tRAYWEIGHT = value;
            }
            get
            {
                return tRAYWEIGHT;
            }
        }
        private Int16 tRAYWEIGHT = 0;

        /// <summary>
        /// ��ע
        /// </summary>
        public string NOTE
        {
            set
            {
                nOTE = value;
            }
            get
            {
                return nOTE;
            }
        }
        private string nOTE = string.Empty;


        /// <summary>
        /// ��ͬ����
        /// </summary>
        public string CONTRACT
        {
            set
            {
                cONTRACT = value;
            }
            get
            {
                return cONTRACT;
            }
        }
        private string cONTRACT = string.Empty;
    }
}