using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZHMHN.IBase;
using ZZHMHN.Web.Entity.Ihpms;
using ZZHMHN.Web.Entity.Select;

namespace ZZHMHN.Web.View.RoadManager
{
    public partial class FrmMutipleParameterManager : System.Web.UI.Page
    {
        public string Road_ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Common.Cookie.MyCookieHelper.GetCookieValue("road_id") != null)
                {
                    //ViewState["Road_ID"]  = Common.Cookie.MyCookieHelper.GetCookieValue("road_id");
                    ViewState["Road_ID"]  = Road_ID = "84";
                }
                BindRoadName(Road_ID);
            }
            if (ViewState["Road_ID"] != null)
            {
                Road_ID = ViewState["Road_ID"].ToString();
            }
        }

        //应该来自用户数据库
        void BindRoadName(string Road_ID)
        {
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

                ddl_RoadName.SelectedIndex = 0;

                ddl_RoadName_SelectedIndexChanged(this, null);
            }
        }

        //查询用户库的SegID
        private string GetSegID()
        {
            string segIDs = "";
            using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            {
                sence.Context = new ZZHMHN.Web.Core.InvokeContext("", ViewState["Road_ID"].ToString());
                List<Selection> lstSelection = sence.Bll.Selection.Get<Selection>();
                foreach (Selection s in lstSelection)
                {
                    segIDs += s.SEGID + ",";
                }
                if (segIDs != "")
                {
                    segIDs = segIDs.Substring(0, segIDs.Length - 1);
                }

            }
            Session["segIDs"] = segIDs;
            return segIDs;
        }
        //绑定开始
        void BindBegin(string segIDs)
        { 
             int rowNum = Convert.ToInt32(ddl_RoadName.SelectedValue);
            List<INVNTORY> lst = MyApp.Bll.Inventory.GetBegin<INVNTORY>(rowNum,  segIDs);
            if(lst.Count > 0)
            {
                ddl_begin.DataSource = lst;
                if (rdList.SelectedIndex == 0)
                {
                    ddl_begin.DataTextField = "BEGINMP";
                }
                else
                {
                    ddl_begin.DataTextField = "FROMLOC";
                }
                ddl_begin.DataValueField = "BEGINMP";
                ddl_begin.DataBind();
                ddl_begin.SelectedIndex = 0;
            }
        }


        //绑定结束
        void BindEnd()
        {
            List<INVNTORY> lst = null;
            int rowNum = Convert.ToInt32(ddl_RoadName.SelectedValue);
            if (rdList.SelectedIndex == 0)
            {
                lst = MyApp.Bll.Inventory.GetEnd<INVNTORY>(rowNum, ddl_begin.Text);
            }
            else if (rdList.SelectedIndex == 1)
            {
                lst = MyApp.Bll.Inventory.GetEnd<INVNTORY>(rowNum, ddl_begin.Items[ddl_begin.Items.Count - 1].Value);
            }
            if (lst != null && lst.Count > 0)
            {
                ddl_end.DataSource = lst;
                if (rdList.SelectedIndex == 0)
                {

                    ddl_end.DataTextField = "ENDMP";
                }
                else
                {
                    ddl_end.DataTextField = "TOLOC";
                }

                ddl_end.DataValueField = "ENDMP";
                ddl_end.DataBind();
                ddl_end.SelectedIndex = 0;
            }

        }
        protected void rdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空begin和end
            ddl_begin.Items.Clear();
            ddl_end.Items.Clear();
            //取SEGID
            string segIDs = GetSegID();
            //查询begin
            BindBegin(segIDs);
            //查询end
            BindEnd();
        }

        protected void ddl_RoadName_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdList_SelectedIndexChanged(this, null);
        }

        protected void ddl_begin_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindEnd();
        }

        protected void btn_ZB_Click(object sender, EventArgs e)
        {
            string js = @"<script>window.open('FrmUpdateParm.aspx?Road_ID="
                + ViewState["Road_ID"].ToString() + "&RoadCode="
                + ddl_RoadName.SelectedValue + "&BeginPoint="
                + ddl_begin.SelectedValue + "&EndPotin=" + ddl_end.SelectedValue +"','height=400','width=600');</script>";

            //string js = "<script>window.open('FrmUpdateParm.aspx?Road_ID=84&RoadCode=1&BeginPoint=360.75&EndPotin=373','height=800','width=600');</script>";
            Response.Write(js);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string js = @"<script>window.open('FrmMillMultiple.aspx?Road_ID="
                + ViewState["Road_ID"].ToString() + "&RoadCode="
                + ddl_RoadName.SelectedValue + "&BeginPoint="
                + ddl_begin.SelectedValue + "&EndPotin=" + ddl_end.SelectedValue 
                + "','height=400','width=600');</script>";
            Response.Write(js);
        }

        protected void btn_Layer_Click(object sender, EventArgs e)
        {
            string js = @"<script>window.open('FrmAddLayer.aspx?Road_ID="
               + ViewState["Road_ID"].ToString() + "&RoadCode="
               + ddl_RoadName.SelectedValue + "&BeginPoint="
               + ddl_begin.SelectedValue + "&EndPotin=" + ddl_end.SelectedValue
               + "','height=400','width=600');</script>";
            Response.Write(js);
        }

    }
}