using System;
using System.Data;
using System.Data.SqlTypes;
namespace SdlDB.Entity
{
    /// <summary>
    /// sdl_FinishedProductsExchangeIn ��ժҪ˵��
    /// </summary>
    [Serializable()]
    public class Sdl_FinishedProductsExchange
    {
        public Sdl_FinishedProductsExchange()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }

        /// <summary>
        /// �볧ID
        /// </summary>
        private int iD = 0;
        public int ID
        {
            set
            {
                iD = value;
            }
            get
            {
                return iD;
            }
        }

        /// <summary>
        /// OA����
        /// </summary>
        private string oANUM = string.Empty;
        public string OANUM
        {
            set
            {
                oANUM = value;
            }
            get
            {
                return oANUM;
            }
        }

        /// <summary>
        /// ʱ���
        /// </summary>
        private string tIMEFLAG = string.Empty;
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


        /// <summary>
        /// ����Ŀ
        /// </summary>
        public string POSNR
        {
            set
            {
                pOSNR = value;
            }
            get
            {
                return pOSNR;
            }
        }
        private string pOSNR = string.Empty;


        /// <summary>
        /// ���ϱ��
        /// </summary>
        public string MATNR
        {
            set
            {
                mATNR = value;
            }
            get
            {
                return mATNR;
            }
        }
        private string mATNR = string.Empty;


        /// <summary>
        /// ��������
        /// </summary>
        public string MAKTX
        {
            set
            {
                mAKTX = value;
            }
            get
            {
                return mAKTX;
            }
        }
        private string mAKTX = string.Empty;

        /// <summary>
        /// ԭ������
        /// </summary>
        public decimal MENGE
        {
            set
            {
                mENGE = value;
            }
            get
            {
                return mENGE;
            }
        }
        private decimal mENGE = 0;

        /// <summary>
        /// ʵ�ռ���
        /// </summary>
        public decimal REALZFIMG
        {
            set
            {
                rEALZFIMG = value;
            }
            get
            {
                return rEALZFIMG;
            }
        }
        private decimal rEALZFIMG = 0;

        /// <summary>
        /// ʵ�ն���
        /// </summary>
        public decimal SENGE
        {
            set
            {
                sENGE = value;
            }
            get
            {
                return sENGE;
            }
        }
        private decimal sENGE = 0;

        /// <summary>
        /// ʵ������
        /// </summary>
        public decimal ZFIMG
        {
            set
            {
                zFIMG = value;
            }
            get
            {
                return zFIMG;
            }
        }
        private decimal zFIMG = 0;

        /// <summary>
        /// ʵ������
        /// </summary>
        public decimal LFIMG
        {
            set
            {
                lFIMG = value;
            }
            get
            {
                return lFIMG;
            }
        }
        private decimal lFIMG = 0;

        /// <summary>
        /// ���ص�
        /// </summary>
        public string LGORT
        {
            set
            {
                lGORT = value;
            }
            get
            {
                return lGORT;
            }
        }
        private string lGORT = string.Empty;

        /// <summary>
        /// �ذ����
        /// </summary>
        private string dBNUM = string.Empty;
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

        /// <summary>
        /// ���ƺ�
        /// </summary>
        private string tRUCKNUM = string.Empty;
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
    }
}