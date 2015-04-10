using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZHMHN.Common.Exception;
using System.Data.SqlClient;
namespace ZZHMHN.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
                int i = 12;
                int b = 0;

                int s = i / b;

           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("abc");
                con.Open();

            }
            catch
            {
                throw new CustomException(CustomExceptionType.DataProvider);
            }
        }
    }
}