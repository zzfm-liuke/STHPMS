using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.DAL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.IBase.I_Entity.Ihpms;
using ServiceStack.OrmLite;
using ZZHMHN.Common.Extension;

namespace ZZHMHN.DAL.Repository
{
    public class CodeInfoRepository : DalBase, ICodeInfoRepository
    {

       
        public List<T> Get<T>(T entity) where T : ICODEINFO
        {
            //using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            //{
            //    return conn.SelectFmt<T>("select * from CODEINFO where STNDNAME = {0} and info != 'no data'", entity.STNDNAME);
            //}
            string databaseId = this.Scene.Context.RoadWayDatabaseId;
            string databaseName = databaseId.GetDatbaseNameById();

            using (IRoadsDao dao = this.Scene.Dal.RoadsDao)
            {
                dao.DataSource = databaseName;
                using (IDbConnection conn = dao.IHPMS.OpenDbConnection())
                {
                    return conn.SelectFmt<T>("select * from CODEINFO where STNDNAME = {0} and info != 'no data'", entity.STNDNAME);
                }
            }
        }


        public List<int> GetMaxNum()
        {
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                return conn.Column<int>("SELECT Max(CODE) AS MAXRNUM FROM CODEINFO WHERE STNDNAME = 'ROADWAY.ROADNUM'");
            }
        }


        public List<int> GetCodeInWorkArea(string StndName,ref int NumElts)
        {
            string databaseId = this.Scene.Context.RoadWayDatabaseId;
            string databaseName = databaseId.GetDatbaseNameById();
            List<int> ret=new List<int>();

            using (IRoadsDao dao = this.Scene.Dal.RoadsDao)
            {
                dao.DataSource = databaseName;
                using (IDbConnection conn = dao.IHPMS.OpenDbConnection())
                {
                    ret= conn.Column<int>(string.Format("SELECT CODE FROM CODEINFO WHERE STNDNAME = '{0}' AND CODE>0",StndName));
                }
            }
            NumElts=ret.Count;
            return ret;
        }
    }
}
