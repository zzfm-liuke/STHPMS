using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZHMHN.IBase;
using ZZHMHN.Web.Entity.Ihpms;
using ZZHMHN.Common;

namespace ZZHMHN.Web.View.RoadManager
{
    public partial class FrmDataBaseManager : System.Web.UI.Page
    {
        private ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AspNetPager1.CurrentPageIndex = 1;
                AspNetPager1.PageSize = 10;
                AspNetPager1.RecordCount = (int)MyApp.Bll.RoadDatabase.GetRecordCount();
                BindData();
            }
        }


        private List<t_basis_road> GetData()
        {
            int skip=(AspNetPager1.CurrentPageIndex-1)*AspNetPager1.PageSize;
            int rows = AspNetPager1.PageSize;
            List<t_basis_road> roads = MyApp.Bll.RoadDatabase.Get<t_basis_road>(skip, rows);
            if (roads.Count == 0)
                roads.Add(new t_basis_road());

            return roads;
        }

        private void BindData()
        {
            GridView1.DataSource = GetData();
            GridView1.DataBind();
        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
           AspNetPager1.CurrentPageIndex = e.NewPageIndex;
           BindData();
        }

        protected void AddNewAction(object sender, EventArgs e)
        {
            try
            {
                t_basis_road road = new t_basis_road();
                road.name = ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text;
                road.comment = ((TextBox)GridView1.FooterRow.FindControl("txtComment")).Text;

                if (MyApp.Bll.RoadDatabase.ExistRoad(new { name = road.name }))
                {
                    ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "nameKey", "alert('路网数据库名称已经存在!');", true);
                    return;
                }

                string datasource = MyApp.Bll.RoadDatabase.Add(road);
                MyApp.Dal.DatabaseManagerRepository.CopyData<ACTIVITY>(datasource);
                MyApp.Dal.DatabaseManagerRepository.CopyData<CODEINFO>(datasource);
                MyApp.Dal.DatabaseManagerRepository.CopyData<DTBRANCH>(datasource);
                MyApp.Dal.DatabaseManagerRepository.CopyData<DTPARAM>(datasource);
                MyApp.Dal.DatabaseManagerRepository.CopyData<MRPOLICY>(datasource);
                MyApp.Dal.DatabaseManagerRepository.CopyData<MRPOLICYSET>(datasource);
                MyApp.Dal.DatabaseManagerRepository.CopyData<PMSELTS>(datasource);
                MyApp.Dal.DatabaseManagerRepository.CopyData<PREF_ITEM>(datasource);

                AspNetPager1.RecordCount = (int)MyApp.Bll.RoadDatabase.GetRecordCount();
                AspNetPager1.CurrentPageIndex = AspNetPager1.PageCount;

                List<t_basis_road> roads = GetData();
                GridView1.DataSource = roads;
                GridView1.DataBind();


                Label lblRoadBaseName = Master.FindControl("lblRoadDatabaseName") as Label;
                lblRoadBaseName.Text =string.Format("当前打开的路网为:{0}",road.name);
                HiddenField lblRoadBaseId = Master.FindControl("lblRoadDatabaseId") as HiddenField;
                lblRoadBaseId.Value = road.id.ToString();


            }
            catch (Exception ex)
            {
                _logger.ErrorFormat("创建路网数据库失败!", ex.Message);
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "nameKey", "alert('创建路网数据库失败!');", true);                  
            }
        }

        protected void DeleteAction(object sender, EventArgs e)
        {
            try
            {                
                LinkButton lnkRemove = (LinkButton)sender;
                MyApp.Bll.RoadDatabase.Remove(lnkRemove.CommandArgument);


                AspNetPager1.RecordCount = (int)MyApp.Bll.RoadDatabase.GetRecordCount();
                List<t_basis_road> roads = GetData();

                GridView1.DataSource = roads;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                _logger.ErrorFormat("删除路网数据库失败!", ex.Message);
                ScriptManager.RegisterClientScriptBlock((sender as Control), this.GetType(), "nameKey", "alert('删除路网数据库失败!');", true);    
            }
        }
        protected void OpenAction(object sender, EventArgs e)
        {
            LinkButton lnkOpen = (LinkButton)sender;
            int rowIndex = int.Parse(lnkOpen.CommandArgument);
            t_basis_road road = new t_basis_road();
            string txtId = GridView1.DataKeys[rowIndex].Values[0].ToString();
            if (!string.IsNullOrEmpty(txtId))
            {
                road.id = Convert.ToInt32(txtId);
                road.name = ((Label)GridView1.Rows[rowIndex].FindControl("lblName")).Text;
                road.comment = ((Label)GridView1.Rows[rowIndex].FindControl("lblComment")).Text;
            }

            Label lblRoadBaseName = Master.FindControl("lblRoadDatabaseName") as Label;
            lblRoadBaseName.Text = string.Format("当前打开的路网为:{0}", road.name);
            HiddenField lblRoadBaseId = Master.FindControl("lblRoadDatabaseId") as HiddenField;
            lblRoadBaseId.Value = road.id.ToString();

            Common.Cookie.MyCookieHelper.SetCookie("road_id", road.id.ToString());//写入Cookie

            //using (ZZHMHN.IBase.I_Core.IScene sence = MyApp.Scene)
            //{
            //    sence.Context = new ZZHMHN.Web.Core.InvokeContext("", road.id.ToString());
            //    sence.Bll.Test.TestScence();
            //}
            
        }

        protected void EditAction(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void CancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void UpdateAction(object sender, GridViewUpdateEventArgs e)
        {            
            t_basis_road road = new t_basis_road();
            string txtId = GridView1.DataKeys[e.RowIndex].Values[0].ToString();
            if (!string.IsNullOrEmpty(txtId))
            {
                road.id = Convert.ToInt32(txtId);
                road.name = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtName")).Text;
                road.comment = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtComment")).Text;
                MyApp.Bll.RoadDatabase.Update(road);
            }

            List<t_basis_road> roads = GetData();
            GridView1.EditIndex = -1;
            GridView1.DataSource = roads;
            GridView1.DataBind();

        }
    }
}