using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZHMHN.IBase;
using ZZHMHN.Web.Entity.Ihpms;
//using ZZHMHN.Web.Entity.Select;
using Microsoft.VisualBasic;

namespace ZZHMHN.Web.View.RoadManager
{
    public partial class FrmAddLayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ViewState["Road_ID"] = Request.QueryString["Road_ID"];
                ViewState["Road_ID"] = "84";
                BindRType(ViewState["Road_ID"].ToString());
                BindStrength(ViewState["Road_ID"].ToString());
                BindAsphalt(ViewState["Road_ID"].ToString());
                BindMatl(ViewState["Road_ID"].ToString());

                txtConstYear.Text = DateTime.Now.ToShortDateString();
                //道路编号，开始点和结束点
                ViewState["RoadCode"] = Request.QueryString["RoadCode"];
                ViewState["BeginPoint"] = Request.QueryString["BeginPoint"];
                ViewState["EndPotin"] = Request.QueryString["EndPotin"];

            }
        }

        //层类型
        void BindRType(string Road_ID)
        {
            //应该来自用户数据库
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                CODEINFO temp = new CODEINFO();
                temp.STNDNAME = "RDLAY.LAYERTYPE";
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                List<CODEINFO> lst = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                cmbType.DataSource = lst;
                cmbType.DataTextField = "info";
                cmbType.DataValueField = "CODE";
                cmbType.DataBind();

                cmbType.SelectedIndex = 0;
            }
        }

        //强度类型
        void BindStrength(string Road_ID)
        {
            //应该来自用户数据库
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                CODEINFO temp = new CODEINFO();
                temp.STNDNAME = "RDLAY.STRGTHTYPE";
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                List<CODEINFO> lst = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                cmbStrength.DataSource = lst;
                cmbStrength.DataTextField = "info";
                cmbStrength.DataValueField = "CODE";
                cmbStrength.DataBind();

                cmbStrength.SelectedIndex = 0;
            }
        }

        //添加类型
        void BindAsphalt(string Road_ID)
        {
            //应该来自用户数据库
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                CODEINFO temp = new CODEINFO();
                temp.STNDNAME = "RDLAY.ASPHTYPE";
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                List<CODEINFO> lst = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                cmbAsphalt.DataSource = lst;
                cmbAsphalt.DataTextField = "info";
                cmbAsphalt.DataValueField = "CODE";
                cmbAsphalt.DataBind();

                cmbAsphalt.SelectedIndex = 0;
            }
        }

        //材料类型
        void BindMatl(string Road_ID)
        {
            //应该来自用户数据库
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                CODEINFO temp = new CODEINFO();
                temp.STNDNAME = "RDLAY.MTRLTYPE";
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                List<CODEINFO> lst = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                List<CODEINFO> newLst = new List<CODEINFO>();
                foreach (CODEINFO c in lst)
                {
                    if ((c.CODE >= 120 && c.CODE <= 139) || (c.CODE >= 170 && c.CODE <= 190))
                    {
                        newLst.Add(c);
                    }
                }
                cmbMatl.DataSource = newLst;
                cmbMatl.DataTextField = "info";
                cmbMatl.DataValueField = "CODE";
                cmbMatl.DataBind();

                cmbMatl.SelectedIndex = 0;
            }
        }

        protected void btn_OK_Click(object sender, EventArgs e)
        {
            if (Common.Rex.Regexlib.IsNumber(txtStrYear.Text) == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('强度年限必须为有效数字');</script>");
                return;
            }
            if (Common.Rex.Regexlib.IsNumber(txtConstYear.Text) == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('施工年限必须为有效数字');</script>");
                return;
            }
            if (Common.Rex.Regexlib.IsNumber(txtStrength.Text) == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('强度值必须为有效数字');</script>");
                return;
            }
            if (Common.Rex.Regexlib.IsNumber(txtDrainage.Text) == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('排水系数必须为有效数字');</script>");
                return;
            }
            if (Common.Rex.Regexlib.IsNumber(txtThickness.Text) == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('结构层厚度必须为有效数字');</script>");
                return;
            }

            List<RDLAY> SegDs = MyApp.Bll.RdLayBill.GetMaxLayNum<RDLAY>(ViewState["RoadCode"].ToString(), Session["segIDs"].ToString(), ViewState["BeginPoint"].ToString(), ViewState["EndPotin"].ToString());
            if (SegDs.Count > 0)
            {

                foreach (RDLAY r in SegDs)
                {
                    //添加结构层
                    r.LAYERNUM = r.LAYERNUM + 1;
                    r.LAYERTYPE = cmbType.SelectedValue;
                    r.LAYERTHICK = float.Parse(txtThickness.Text);
                    r.LAYERM = float.Parse(txtDrainage.Text);
                    r.MTRLTYPE = cmbMatl.SelectedValue;
                    r.ASPHTYPE = cmbAsphalt.SelectedValue;
                    r.STRGTHTYPE = cmbStrength.SelectedValue;
                    r.STRGTHVAL = float.Parse(txtStrength.Text);
                    r.STRGTHYEAR = short.Parse(txtStrYear.Text);//强度年限
                    r.CONSTYEAR = short.Parse(txtConstYear.Text);//施工年限
                    r.COMMENTS = txtComments.Text;
                    r.REVDATE = DateTime.Now;

                    MyApp.Bll.RdLayBill.Insert(r);
                }
            }
            //执行成功
            Response.Write("<script>alert('执行成功!');window.close();</script>");

        }
    }
}