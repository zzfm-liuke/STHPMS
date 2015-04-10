using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using Newtonsoft.Json;
using ZZHMHN.IBase;

namespace ZZHMHN.Web
{
    /// <summary>
    /// Handler_Navigation 的摘要说明
    /// </summary>
    public class Handler_Navigation : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write(MyApp.Bll.Navigation.GetData());
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}