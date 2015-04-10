using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace ZZHMHN.Web.View.LoadManager.ashx
{
    /// <summary>
    /// RoadService 的摘要说明
    /// </summary>
    public class RoadService : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string str = string.Empty;
            int pageIndex = Convert.ToInt32(context.Request["pageIndex"]);
            int size = Convert.ToInt32(context.Request["pageSize"]);
            if (pageIndex == 0)
            {
                pageIndex = 1;
            }

            List<TestJSON> temp = new  List<TestJSON>();
            using (SqlConnection con = new SqlConnection("server=192.168.0.111;database=grid_test;uid=sa;pwd=123"))
            {
                con.Open();
                string sql = "SELECT TOP " + size + " *  FROM t_man   WHERE id NOT IN  (  SELECT TOP " + size * (pageIndex - 1) + " id FROM t_man ORDER BY id  )  ORDER BY id ";
                SqlDataAdapter da = new SqlDataAdapter(sql,con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    temp.Add(
                         new TestJSON
                         {
                             ID = dr[0].ToString(),
                             Title = dr[1].ToString(),
                             Time = dr[3].ToString()
                         }
                        );
                }
            }
            TestListJSON tList = new TestListJSON();
            tList.total = 40;//总记录数查询emp
            //查询记录
            tList.rows = temp;
            
            //json序列化
            context.Response.Write(JsonConvert.SerializeObject(tList));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

    }
    class TestListJSON
    {
        //记录总数
        public int total { get; set; }
        //多条记录
        public List<TestJSON> rows { get; set; }
    }

    class TestJSON
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
       
    }
}