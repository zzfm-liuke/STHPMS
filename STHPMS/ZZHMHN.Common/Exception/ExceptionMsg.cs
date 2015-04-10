using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.Common.Exception
{
    public class ExceptionMsg
    {
        private int messageid = -1;
        private string title = "";
        private string body = "";

        public int MessageId
        {
            get { return messageid; }
            set { messageid = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }
    }
}
