using System;
using System.Data;
using System.Data.SqlTypes;
namespace SdlDB.Entity
{
    /// <summary>
    /// sdl_FinishedProductsExchangeInTitle ��ժҪ˵��
    /// </summary>
    [Serializable()]
    public class Sdl_FinishedProductsExchangeTitle
    {
        public Sdl_FinishedProductsExchangeTitle()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }


        /// <summary>
        /// �볧ID
        /// </summary>
        /// 
        private string iD = string.Empty;
        public string ID
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
        /// OA���뵥��
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
        /// ����
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

        /// <summary>
        /// �볡ʱ��
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
        /// �볧˾��Ա
        /// </summary>
        public string ENTERWEIGHT
        {
            set
            {
                eNTERWEIGHT = value;
            }
            get
            {
                return eNTERWEIGHT;
            }
        }
        private string eNTERWEIGHT = string.Empty;

        /// <summary>
        /// ����ʱ��
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
        /// ����˾��Ա
        /// </summary>
        public string EXITWEIGHT
        {
            set
            {
                eXITWEIGHT = value;
            }
            get
            {
                return eXITWEIGHT;
            }
        }
        private string eXITWEIGHT = string.Empty;

        /// <summary>
        /// �س�������ʶ
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
        /// ë��
        /// </summary>
        public decimal GROSS
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
        private decimal gROSS = 0;



        /// <summary>
        /// Ƥ��
        /// </summary>
        public decimal TARE
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
        private decimal tARE = 0;

        /// <summary>
        /// ����
        /// </summary>
        public decimal NET
        {
            set
            {
                nET = value;
            }
            get
            {
                return nET;
            }
        }
        private decimal nET = 0;

        /// <summary>
        /// ������ʶ
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
        /// �ͻ����
        /// </summary>
        public string CNUM
        {
            set
            {
                cNUM = value;
            }
            get
            {
                return cNUM;
            }
        }
        private string cNUM = string.Empty;

        /// <summary>
        /// �ͻ�����
        /// </summary>
        public string CNAME
        {
            set
            {
                cNAME = value;
            }
            get
            {
                return cNAME;
            }
        }
        private string cNAME = string.Empty;

        /// <summary>
        /// ���˷�ʽ
        /// </summary>
        public string TTYPE
        {
            set
            {
                tTYPE = value;
            }
            get
            {
                return tTYPE;
            }
        }
        private string tTYPE = string.Empty;

        /// <summary>
        /// ��������
        /// </summary>
        public string FXQD
        {
            set
            {
                fXQD = value;
            }
            get
            {
                return fXQD;
            }
        }
        private string fXQD = string.Empty;

        /// <summary>
        /// ҵ��Ա
        /// </summary>
        public string YWY
        {
            set
            {
                yWY = value;
            }
            get
            {
                return yWY;
            }
        }
        private string yWY = string.Empty;

        /// <summary>
        /// ��������
        /// </summary>
        public string XSQY
        {
            set
            {
                xSQY = value;
            }
            get
            {
                return xSQY;
            }
        }
        private string xSQY = string.Empty;

        /// <summary>
        /// ���ۿ���
        /// </summary>
        public string XSKS
        {
            set
            {
                xSKS = value;
            }
            get
            {
                return xSKS;
            }
        }
        private string xSKS = string.Empty;

        /// <summary>
        /// ������־
        /// </summary>
        public string ISOUT
        {
            set
            {
                iSOUT = value;
            }
            get
            {
                return iSOUT;
            }
        }
        private string iSOUT = string.Empty;
    }
}