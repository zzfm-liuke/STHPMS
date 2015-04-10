using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Web.Caching;
using System.Web;

namespace ZZHMHN.Common.Exception
{
    public abstract class ExceptionMsgsManager
    {
        static ExceptionMsgsManager()
        {
            //如果Cache为空的话才执行
            if (HttpRuntime.Cache["ExceptionMsgs"] == null)
            {
                Dictionary<int, ExceptionMsg> MsgsTable = new Dictionary<int, ExceptionMsg>();
                ExceptionMsg em;

                XmlDocument doc = new XmlDocument();
                string XmlPath = HttpContext.Current.Server.MapPath("~/MsgsResource.xml");
                doc.Load(XmlPath);
                XmlNode UrlsRoot = doc.SelectSingleNode("messages");
                foreach (XmlNode node in UrlsRoot.ChildNodes)
                {
                    em = new ExceptionMsg();

                    //用数据构造体装载xml的内容
                    em.MessageId = int.Parse(node.Attributes["id"].Value);
                    em.Title = node.SelectSingleNode("title").InnerText;
                    em.Body = node.SelectSingleNode("body").InnerText;

                    //将填充好的em加载到集合里
                    MsgsTable[em.MessageId] = em;
                }
                //将完整的哈希表插入到Cache
                HttpRuntime.Cache.Insert("ExceptionMsgs", MsgsTable, null, DateTime.MaxValue, TimeSpan.Zero);
            }
        }

        /// <summary>
        /// 读取集合信息的Hashtable
        /// </summary>
        /// <param name="MessageId">xml中定义的messageid</param>
        /// <returns></returns>
        public static ExceptionMsg GetExceptionMsg(int MessageId)
        {
            Dictionary<int, ExceptionMsg> Msgs = (Dictionary<int, ExceptionMsg>)HttpRuntime.Cache["ExceptionMsgs"];
            return (ExceptionMsg)Msgs[MessageId];
        }
    }
}
