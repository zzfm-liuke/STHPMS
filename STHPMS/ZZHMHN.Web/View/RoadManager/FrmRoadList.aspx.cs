using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZHMHN.Web.View.LoadManager
{
    public partial class FrmRoadList : System.Web.UI.Page
    {
        public string pageIndex = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["pageIndex"] != null)
                {
                    pageIndex = Request["pageIndex"];
                }
            }
        }
    }
}