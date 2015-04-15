using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZHMHN.IBase;
using ZZHMHN.Web.Entity.Ihpms;


namespace ZZHMHN.Web.View.RoadManager
{
    public partial class FrmEditRoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Road_ID = Request.QueryString["Road_ID"];
                BindFacility(Road_ID);
                BindRoadName(Road_ID);
                BindRidDir(Road_ID);
                BindSecDir(Road_ID);
                txt_BeginTime.Text = DateTime.Now.ToShortDateString();
            }
        }

        //设施
        void BindFacility(string Road_ID)
        { 
            //应该来自用户数据库
            //取出Road.ID
             using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
             {
                 CODEINFO temp = new CODEINFO();
                 temp.STNDNAME = "ROADWAY.FACILITY";
                 sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                 List<CODEINFO> lst = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                 lst_Facility.DataSource = lst;
                 lst_Facility.DataTextField = "info";
                 lst_Facility.DataValueField = "CODE";
                 lst_Facility.DataBind();

                 if (lst_Facility.Items.Count > -1)
                 {
                     lst_Facility.SelectedIndex = 0;
                 }
             }

           
            //CODEINFO temp = new CODEINFO();
            //temp.STNDNAME = "ROADWAY.FACILITY";
            //List<CODEINFO> lst = MyApp.Bll.CodeInfo.Get<CODEINFO>(temp);
            
        }

        //道路名称
        void BindRoadName(string Road_ID)
        {
            //应该来自用户数据库
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                CODEINFO temp = new CODEINFO();
                temp.STNDNAME = "ROADWAY.ROADNUM";
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                List<CODEINFO> lst = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                ddl_RoadName.DataSource = lst;
                ddl_RoadName.DataTextField = "info";
                ddl_RoadName.DataValueField = "CODE";
                ddl_RoadName.DataBind();
            }
        }

        //主要方向
        void BindRidDir(string Road_ID)
        {
            //应该来自用户数据库
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                CODEINFO temp = new CODEINFO();
                temp.STNDNAME = "ROADWAY.PRIMARYDIR";
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                List<CODEINFO> lst = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                ddl_PriDir.DataSource = lst;
                ddl_PriDir.DataTextField = "info";
                ddl_PriDir.DataValueField = "CODE";
                ddl_PriDir.DataBind();
            }
        }
        //次要方向
        void BindSecDir(string Road_ID)
        {
            //应该来自用户数据库
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                CODEINFO temp = new CODEINFO();
                temp.STNDNAME = "ROADWAY.SECONDDIR";
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", Road_ID);
                List<CODEINFO> lst = sence.Bll.CodeInfo.Get<CODEINFO>(temp);
                ddl_SecDir.DataSource = lst;
                ddl_SecDir.DataTextField = "info";
                ddl_SecDir.DataValueField = "CODE";
                ddl_SecDir.DataBind();
            }
        }
        protected void btn_OK_Click(object sender, EventArgs e)
        {
            //添加道路设备
            string FacilCode = lst_Facility.SelectedValue;
             //FacilCode& = FacilityList.ItemData(FacilityList.ListIndex) 得到被选的设备value
             bool RoadFound = false;
            //判断是否在Codeinfo已经存在,赋值给 RoadFound%
             //应该来自用户数据库
             CODEINFO temp = new CODEINFO();
             temp.STNDNAME = "ROADWAY.ROADNUM";
             temp.INFO = ddl_RoadName.SelectedItem.Text;
             List<CODEINFO> lst = MyApp.Bll.CodeInfo.Get<CODEINFO>(temp);
             int curCode = 0;
             foreach (CODEINFO code in lst)
             { 
                //取出当前RoadNum
                 if (code.INFO == temp.INFO)
                 {
                     curCode = code.CODE;
                     RoadFound = true;
                     break;
                 }
             }

             if (!RoadFound)
             {
                 //     RNumCode&  =    SELECT Max(Val(CODE)) AS MAXRNUM FROM CODEINFO WHERE STNDNAME = 'ROADWAY.ROADNUM'  +1 
                 
                 CODEINFO code = new CODEINFO
                 {
                     CODE = MyApp.Bll.CodeInfo.GetMaxNum()[0] + 1,//应该来自基础数据库
                     STNDNAME = "ROADWAY.ROADNUM",
                     INFO = ddl_RoadName.Text // 道路名称
                 };

                 MyApp.Bll.CodeInfo.Insert(code);//保存到基础数据库
             }
             else
             {
                 ROADWAY r = new ROADWAY() { 
                    FACILITY = FacilCode,
                    ROADNUM = curCode.ToString()
                 };
                 if (MyApp.Bll.RoadWay.Get<ROADWAY>(r).Count > 0) //应该来自基础数据库
                 {
                     ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('所选道路已存在的此设备,无法添加一个新的道路');</script>");
                     return;
                 }
             }
           // else{
            //SELECT * FROM ROADWAY WHERE FACILITY = '" & Format$(FacilCode&) & "' AND ROADNUM = ' + curCode
                //提示已经存在
          //  }

            //Find new RDWAYID.
            ROADWAY roadWayInfo = new ROADWAY {
                RDWAYID = MyApp.Bll.RoadWay.GetMaxNum()[0] + 1, //应该来自基础数据库
                 FACILITY = FacilCode,
                 REVDATE = DateTime.Now,
                PRIMARYDIR = ddl_PriDir.SelectedValue.ToString(),
                SECONDDIR = ddl_SecDir.SelectedValue.ToString(),
                COMMENTS = txt_Comment.Text,
                BEGINDATE = Convert.ToDateTime( txt_BeginTime.Text),
                TYPE="1",
                STATUS="1",
                MAINTRESP = "1",
                ROADNUM = curCode.ToString()
            };
          
              //RdWayDs("ROADNUM") = Format$(RNumCode&)

            MyApp.Bll.RoadWay.Insert(roadWayInfo); //应该来自基础数据库
              //添加到roadway表
            Response.Write("<script>alert('添加成功！');window.opener.location.href=window.opener.location.href;window.close();</script>");
        }
    }
}