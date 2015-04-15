using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.DAL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.IBase.I_Entity.ISelect;
using ServiceStack.OrmLite;
using ZZHMHN.Common.Extension;

namespace ZZHMHN.DAL.Repository
{
    public class SelectionRepository : DalBase, ISelectionRepository
    {
        public List<T> Get<T>() where T : class, ISelection
        {
            string databaseId = this.Scene.Context.RoadWayDatabaseId;
            string databaseName = databaseId.GetDatbaseNameById();

            using (IRoadsDao dao = this.Scene.Dal.RoadsDao)
            {
                dao.DataSource = databaseName;
                using (IDbConnection conn = dao.Select.OpenDbConnection())
                {
                    return conn.SelectFmt<T>("select * from Selection");
                }
            }
        }
    }
}
