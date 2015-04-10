using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.Common.Exception
{ 
    //定义异常枚举类型,编号和xml对应
    public enum CustomExceptionType
    {
        DataProvider = 0,//数据提供错误
        PageUrlError = 1//地址错误
    }

    public class CustomException : ApplicationException
    {
        #region 成员

        CustomExceptionType exceptionType;

        public CustomExceptionType ExceptionType
        {
            get
            {
                return exceptionType;
            }
        }

        #endregion

        #region 构造函数

        public CustomException(CustomExceptionType t)
            : base()
        {
            Init();
            this.exceptionType = t;
        }

        public CustomException(CustomExceptionType t, string message)
            : base(message)
        {
            Init();
            this.exceptionType = t;
        }

        public CustomException(CustomExceptionType t, string message, System.Exception inner)
            : base(message, inner)
        {
            Init();
            this.exceptionType = t;
        }

        #endregion

        #region 重写的方法

        public override string Message
        {
            get
            {
                return base.Message;
            }
        }

        public override int GetHashCode()
        {
            string stringToHash = (exceptionType + base.Message);

            return stringToHash.GetHashCode();

        }

        #endregion

        #region 错误产生的属性
        string userAgent = string.Empty;
        public string UserAgent
        {
            get { return userAgent; }
            set { userAgent = value; }
        }

        public int Category
        {
            get { return (int)exceptionType; }
            set { exceptionType = (CustomExceptionType)value; }
        }

        string ipAddress = string.Empty;
        public string IPAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

        string httpReferrer = string.Empty;
        public string HttpReferrer
        {
            get { return httpReferrer; }
            set { httpReferrer = value; }
        }

        string httpVerb = string.Empty;
        public string HttpVerb
        {
            get { return httpVerb; }
            set { httpVerb = value; }
        }

        string httpPathAndQuery = string.Empty;
        public string HttpPathAndQuery
        {
            get { return httpPathAndQuery; }
            set { httpPathAndQuery = value; }
        }

        DateTime dateCreated;
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        DateTime dateLastOccurred;
        public DateTime DateLastOccurred
        {
            get { return dateLastOccurred; }
            set { dateLastOccurred = value; }
        }
        int frequency = 0;
        public int Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        string stackTrace = string.Empty;
        public string LoggedStackTrace
        {
            get
            {
                return stackTrace;
            }
            set
            {
                stackTrace = value;
            }
        }

        int exceptionID = 0;
        public int ExceptionID
        {
            get
            {
                return exceptionID;
            }
            set
            {
                exceptionID = value;
            }
        }
        #endregion

        #region 异常产生后要做的事情

        private void Init()
        {
            //这里暂时为空，要用到的时候再写
        }

        #endregion
    }
}
