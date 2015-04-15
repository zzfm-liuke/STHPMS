using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Wuqi.Webdiyer;//分页控件
using ZZHMHN.IBase;
using ZZHMHN.Web.Entity.Ihpms;
using ZZHMHN.Common;

namespace ZZHMHN.Web.View.RoadManager
{
    public partial class FrmRoadManager : System.Web.UI.Page
    {
        public string Road_ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                //获取总记录数
                AspNetPager1.RecordCount = (int)MyApp.Bll.RoadWay.GetRecordCount();
                if (Common.Cookie.MyCookieHelper.GetCookieValue("road_id") != null)
                {
                    Road_ID = Common.Cookie.MyCookieHelper.GetCookieValue("road_id");
                }
                Bind();
            }
        }

        private List<Entity.Ihpms.View.ROADWAY_View> GetData()
        {
            int skip = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize;
            int rows = AspNetPager1.PageSize;
            List<Entity.Ihpms.View.ROADWAY_View> roads = MyApp.Bll.RoadWay.Get<Entity.Ihpms.View.ROADWAY_View>(skip, rows);
            if (roads.Count == 0)
                roads.Add(new Entity.Ihpms.View.ROADWAY_View());

            return roads;
        }

        private void Bind()
        {
            dgv_Man.DataSource = GetData();
            dgv_Man.DataBind();
        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind();
        }

        

        //编辑事件
        protected void dgv_Man_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgv_Man.EditIndex = e.NewEditIndex;
            Bind();
        }

        //取消编辑事件
        protected void dgv_Man_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgv_Man.EditIndex = -1;
            Bind();
        }

        protected void dgv_Man_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //修改绑定道路名称
                if ((DropDownList)e.Row.FindControl("ddl_Road") != null)
                {

                    if ((e.Row.RowState & DataControlRowState.Edit) != 0)
                    {
                        DropDownList ddl_Road = (DropDownList)e.Row.FindControl("ddl_Road");
                        if (ddl_Road != null)
                        {
                            HiddenField hd_Road = (HiddenField)e.Row.Cells[1].FindControl("hd_Road");
                            BindDropDownList(ddl_Road, hd_Road.Value, "ROADWAY.ROADNUM");
                        }
                    }
                }

                //修改绑定设施名称
                if ((DropDownList)e.Row.FindControl("ddl_FACILITY") != null)
                {

                    if ((e.Row.RowState & DataControlRowState.Edit) != 0)
                    {
                        DropDownList ddl_FACILITY = (DropDownList)e.Row.FindControl("ddl_FACILITY");
                        if (ddl_FACILITY != null)
                        {
                            HiddenField hd_FACILITY = (HiddenField)e.Row.Cells[2].FindControl("hd_FACILITY");
                            BindDropDownList(ddl_FACILITY, hd_FACILITY.Value, "ROADWAY.FACILITY");
                        }
                    }
                }

                //修改绑定主要方向
                if ((DropDownList)e.Row.FindControl("ddl_PRIMARYDIR") != null)
                {

                    if ((e.Row.RowState & DataControlRowState.Edit) != 0)
                    {
                        DropDownList ddl_PRIMARYDIR = (DropDownList)e.Row.FindControl("ddl_PRIMARYDIR");
                        if (ddl_PRIMARYDIR != null)
                        {
                            HiddenField hd_PRIMARYDIR = (HiddenField)e.Row.Cells[2].FindControl("hd_PRIMARYDIR");
                            BindDropDownList(ddl_PRIMARYDIR, hd_PRIMARYDIR.Value, "ROADWAY.PRIMARYDIR");
                        }
                    }
                }

                //修改绑定次要方向
                if ((DropDownList)e.Row.FindControl("ddl_SECONDDIR") != null)
                {

                    if ((e.Row.RowState & DataControlRowState.Edit) != 0)
                    {
                        DropDownList ddl_SECONDDIR = (DropDownList)e.Row.FindControl("ddl_SECONDDIR");
                        if (ddl_SECONDDIR != null)
                        {
                            HiddenField hd_SECONDDIR = (HiddenField)e.Row.Cells[2].FindControl("hd_SECONDDIR");
                            BindDropDownList(ddl_SECONDDIR, hd_SECONDDIR.Value, "ROADWAY.SECONDDIR");
                        }
                    }
                }
            }
        }

        void BindDropDownList(DropDownList ddl, string keyName, string STNDNAME)
        {
            CODEINFO temp = new CODEINFO();
            temp.STNDNAME = STNDNAME;// "ROADWAY.ROADNUM";
            List<CODEINFO> lst = MyApp.Bll.CodeInfo.Get<CODEINFO>(temp);
            ddl.DataSource = lst;
            ddl.DataTextField = "info";
            ddl.DataValueField = "CODE";
            ddl.DataBind();
            ddl.SelectedItem.Text = keyName;//指定显示项
        }

        protected void dgv_Man_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow drv = ((GridViewRow)(((LinkButton)(e.CommandSource)).Parent.Parent)); //此得出的值是表示那行被选中的索引值
            //取主键
            int key = Convert.ToInt32( dgv_Man.DataKeys[drv.RowIndex].Value);
            if (e.CommandName == "xg") //修改
            {
                //取值
                string RoadNum = ((DropDownList)dgv_Man.Rows[drv.RowIndex].FindControl("ddl_Road")).SelectedValue;
                 string FACILITYNum = ((DropDownList)dgv_Man.Rows[drv.RowIndex].FindControl("ddl_FACILITY")).SelectedValue;
                 string PRIMARYDIRNum = ((DropDownList)dgv_Man.Rows[drv.RowIndex].FindControl("ddl_PRIMARYDIR")).SelectedValue;
                 string SECONDDIRNum = ((DropDownList)dgv_Man.Rows[drv.RowIndex].FindControl("ddl_SECONDDIR")).SelectedValue;
                 DateTime BegeinTime = Convert.ToDateTime( ((TextBox)dgv_Man.Rows[drv.RowIndex].FindControl("txt_Time")).Text);
                 string COMMENTS = ((TextBox)dgv_Man.Rows[drv.RowIndex].FindControl("txt_COMMENTS")).Text;

                 MyApp.Bll.RoadWay.Update(new ROADWAY { RDWAYID = key, ROADNUM = RoadNum, 
                     FACILITY = FACILITYNum, BEGINDATE = BegeinTime, PRIMARYDIR = PRIMARYDIRNum ,
                  SECONDDIR = SECONDDIRNum,COMMENTS= COMMENTS});
            }
            else if (e.CommandName == "del") //删除
            {
                ROADWAY r = new ROADWAY(){
                    RDWAYID = key
                };
                MyApp.Bll.RoadWay.Del(r);
                //Del(key);
            }

            dgv_Man.EditIndex = -1;
            Bind();
        }

    }
}