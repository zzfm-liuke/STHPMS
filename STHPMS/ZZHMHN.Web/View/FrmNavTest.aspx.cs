using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZHMHN.IBase;
using ZZHMHN.Web.Entity.IPCIWCI;

namespace ZZHMHN.Web.View
{
    public partial class FrmNavTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private COEFF_A GetEntity()
        {
            COEFF_A coeff = new COEFF_A(); 
            coeff.Distress_ID=7;
            coeff.Severity=8;
            coeff.Max_Distress_Density=9;
            coeff.A0=0;
            coeff.A1=1;
            coeff.A2=2;
            coeff.A3=3;
            coeff.A4=4;
            coeff.A5=5;
            coeff.A6=6;
        
            return coeff;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            long count = MyApp.Bll.Test.Insert(GetEntity());
            Label1.Text = "add:" + count.ToString();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {            
            COEFF_A coeff = GetEntity();
            coeff.A0 = 10;
            coeff.A1 = 11;
            coeff.A2 = 12;
            coeff.A3 = 13;
            coeff.A4 = 14;
            coeff.A5 = 15;
            coeff.A6 = 16;

            long count = MyApp.Bll.Test.Update(coeff);
            Label1.Text = "update:" + count.ToString();
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            long count = MyApp.Bll.Test.Delete(GetEntity());
            Label1.Text = "delete:" + count.ToString();
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            //List<COEFF_A> lst = MyApp.Bll.Test.Get<COEFF_A>();
            //Label1.Text = "get:" + lst.Count.ToString();

            COEFF_A entity = new COEFF_A();
            entity.Distress_ID = 7;
            List<COEFF_A> lst = MyApp.Bll.Test.Get<COEFF_A>(entity);
            Label1.Text = "get:" + lst.Count.ToString();
        }
    }
}