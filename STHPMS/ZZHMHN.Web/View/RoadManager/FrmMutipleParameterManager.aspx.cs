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
    public partial class FrmMutipleParameterManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRoadName();
            }
        }

        //应该来自用户数据库
        void BindRoadName()
        {
            CODEINFO temp = new CODEINFO();
            temp.STNDNAME = "ROADWAY.ROADNUM";
            List<CODEINFO> lst = MyApp.Bll.CodeInfo.Get<CODEINFO>(temp);
            ddl_RoadName.DataSource = lst;
            ddl_RoadName.DataTextField = "info";
            ddl_RoadName.DataValueField = "CODE";
            ddl_RoadName.DataBind();
        }

        protected void rdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_begin.Items.Clear();
            if (rdList.SelectedIndex == 0)
            {
                lblBegin.Text = "开始站:";
                lblEnd.Text = "结束站:";

                //用户数据库和基础数据库的联查
                // MainDb.OpenRecordset("SELECT INVNTORY.BEGINMP AS NAME, INVNTORY.BEGINMP AS DATA FROM ROADWAY INNER JOIN INVNTORY ON ROADWAY.RDWAYID = INVNTORY.RDWAYID Where ((ROADWAY.RoadNum = '" & cmbRoadName.ItemData(cmbRoadName.ListIndex) & "')) AND SEGID = ANY (SELECT SEGID FROM SELECTION IN '" & WDBPath$ & "SELECT.MDB') ORDER BY BEGINMP, ENDMP", dbOpenDynaset)

            }
            else if (rdList.SelectedIndex == 1)
            {
                lblBegin.Text = "开始位置:";
                lblEnd.Text = "结束位置:";
            }
            //选中的道路编号
            int rowNum = Convert.ToInt32( ddl_RoadName.SelectedValue);
            List<INVNTORY> lst = MyApp.Bll.Inventory.GetBegin<INVNTORY>(rowNum, rdList.SelectedIndex);
            if (lst.Count > 0)
            {
                ddl_begin.DataSource = lst;
                ddl_begin.DataTextField = "Name";
                ddl_begin.DataValueField = "Data";
                ddl_begin.DataBind();
                ddl_begin.Enabled = true;
            }
            else
            {
                ddl_begin.Enabled = false;
                ddl_end.Items.Clear();
                ddl_end.Enabled = false;
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('没有选择这条路段,请选择一个新的道路或改变当前的选择');</script>");
            }
        }

        protected void ddl_RoadName_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdList_SelectedIndexChanged(this, null);
        }

        protected void ddl_begin_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<INVNTORY> lst = null;
             int rowNum = Convert.ToInt32( ddl_RoadName.SelectedValue);
            if (rdList.SelectedIndex == 0)
            {
                lst = MyApp.Bll.Inventory.GetEnd<INVNTORY>(rowNum, ddl_begin.Text);
            }
            else if (rdList.SelectedIndex == 1)
            {
                lst = MyApp.Bll.Inventory.GetEnd<INVNTORY>(rowNum, ddl_begin.Items[ddl_begin.Items.Count-1].Value);
            }
            if (lst != null && lst.Count > 0)
            {
                ddl_end.DataSource = lst;
                ddl_end.DataTextField = "Name";
                ddl_end.DataValueField = "Data";
                ddl_end.DataBind();
                ddl_end.SelectedIndex = 0;
                ddl_end.Enabled = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('这段路不存在。请选择一个新的道路');</script>");
                ddl_end.Enabled = false;
            }
        }
    }
}