using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZHMHN.Common.Exception;

namespace ZZHMHN.Web
{
    public partial class Error : System.Web.UI.Page
    {
        private ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //自定义异常
                if (Request.QueryString["msgid"] != null && Request.QueryString["msgid"] != "-1")
                {
                    try
                    {
                        //根据id获取自定义异常
                        int msgid = int.Parse(Request.QueryString["msgid"]);
                        ExceptionMsg em = ExceptionMsgsManager.GetExceptionMsg(msgid);

                        lblMessage2.Text = "异常信息:" + em.Title;
                        lblMessage3.Text = "详情:" + em.Body + " <br>请点击<a href='" + Request.QueryString["reqUrl"] + "'>此处</a>返回或联系系统管理员";

                        _logger.ErrorFormat("系统错误:{0}-{1}", Title, msgid);
                    }
                    catch (Exception ex)
                    {
                        lblMessage1.Text = ex.Message;
                    }
                }
                else  //系统异常
                {
                    try
                    {
                        lblMessage2.Text = "异常信息:系统异常";
                      
                        lblMessage3.Text = "详情:" + Request.QueryString["errMsg"] + " <br>请点击<a href='" + Request.QueryString["reqUrl"] + "'>此处</a>返回或联系系统管理员";

                        _logger.ErrorFormat("系统异常:{0}", Request.QueryString["errMsg"]);
                    }
                    catch (Exception ex)
                    {
                        lblMessage1.Text = ex.Message;
                    }
                }
            }
        }
    }
}