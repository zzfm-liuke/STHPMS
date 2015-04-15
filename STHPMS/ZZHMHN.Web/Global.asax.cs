using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using ZZHMHN.Common.Exception;
using ZZHMHN.Web.Core;

namespace ZZHMHN.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            new Loader().Start();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
#if _RELEASE
            string reqUrl = HttpContext.Current.Request.Url.ToString();//保存请求的url
            if (Server.GetLastError().GetBaseException() is CustomException) //如果是自定义异常
            { 
                //把抛出的异常的信息读出来
                CustomException ce=(CustomException)Server.GetLastError().GetBaseException();
                //清除之前的异常
                Server.ClearError();
                //带上异常信息的ID跳到错误页
                Response.Redirect("error.aspx?msgid="+ce.ExceptionID+"&reqUrl=" + reqUrl,true);
            }
            else
            {
                Exception objErr = Server.GetLastError().GetBaseException();
                     //清除之前的异常
                Server.ClearError();
                Response.Redirect("error.aspx?msgid=-1&reqUrl=" + reqUrl + "&errMsg=" + objErr.Message , true);
            }
#endif
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}