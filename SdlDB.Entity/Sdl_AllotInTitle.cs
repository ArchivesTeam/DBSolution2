using System;
using System.Data;
using System.Data.SqlTypes;
namespace SdlDB.Entity
{
/// <summary>
/// sdl_AllotInTitle ��ժҪ˵��
/// </summary>
    [Serializable()]
    public class Sdl_AllotInTitle
    {
        public Sdl_AllotInTitle()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }


        /// <summary>
        /// 
        /// </summary>
        //���̱���
        private string tRAYWEIGHT;
        //��������
        private string tRAYNUM;
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
        public double DEDUCTNUM
        {
            set
            {
                dEDUCTNUM = value;
            }
            get
            {
                return dEDUCTNUM;
            }
        }
        private double dEDUCTNUM = 0;


        /// <summary>
        /// 
        /// </summary>
        public string HSFLAG
        {
            set
            {
                hSFLAG = value;
            }
            get
            {
                return hSFLAG;
            }
        }
        private string hSFLAG = string.Empty;


        /// <summary>
        /// 
        /// </summary>
        public string EBELN
        {
            set
            {
                eBELN = value;
            }
            get
            {
                return eBELN;
            }
        }
        private string eBELN = string.Empty;


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
        public string OUTTIMEFLAG
        {
            set
            {
                oUTTIMEFLAG = value;
            }
            get
            {
                return oUTTIMEFLAG;
            }
        }
        private string oUTTIMEFLAG = string.Empty;

        



        /// <summary>
        /// 
        /// </summary>
        public string ENTERWEIGHMAN
        {
            set
            {
                eNTERWEIGHMAN = value;
            }
            get
            {
                return eNTERWEIGHMAN;
            }
        }
        private string eNTERWEIGHMAN = string.Empty;


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
        public string RESWK
        {
            set
            {
                rESWK = value;
            }
            get
            {
                return rESWK;
            }
        }
        private string rESWK = string.Empty;


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

        public string TRAYWEIGHT
        {
            get
            {
                return tRAYWEIGHT;
            }

            set
            {
                tRAYWEIGHT = value;
            }
        }

        public string TRAYNUM
        {
            get
            {
                return tRAYNUM;
            }

            set
            {
                tRAYNUM = value;
            }
        }

        private string dBNUM = string.Empty;
    }

}