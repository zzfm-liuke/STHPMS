using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.DAL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.IBase.I_Entity.IPCIWCI;
using ZZHMHN.Common.Extension;
using ServiceStack.OrmLite;

namespace ZZHMHN.DAL.Repository
{
    /// <summary>
    /// 数据库操作放在Repository
    /// </summary>
    public class TestRepository : DalBase, ITestDal
    {
        public int Add(IBase.I_Entity.ITestEntity entity)
        {
            return entity.X + entity.Y;
        }


        public List<T> Get<T>(T entity) where T : ICOEFF_A
        { 
            using(IDbConnection conn=MyApp.Dal.BasisDao.PCIWCI.OpenDbConnection())
            {
                return conn.SelectFmt<T>("select * from COEFF_A where [Distress ID]={0}", entity.Distress_ID);
            }
        }


        public void TestScence()
        {
            string databaseId=this.Scene.Context.RoadWayDatabaseId;
            string databaseName=databaseId.GetDatbaseNameById();

            using (IRoadsDao dao = this.Scene.Dal.RoadsDao)
            {
                dao.DataSource = databaseName;
                using (IDbConnection conn = dao.IHPMS.OpenDbConnection())
                {
                    conn.ExecuteNonQuery("use ihpms;");
                }
            }
           
        }
    }
}
