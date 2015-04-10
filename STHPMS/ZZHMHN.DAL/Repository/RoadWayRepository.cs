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

namespace ZZHMHN.DAL.Repository
{
    public class RoadWayRepository : DalBase, IRoadWayRepository
    {

        public List<int> GetMaxNum()
        {
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                return conn.Column<int>("SELECT Max(RDWAYID) AS MAXRD FROM ROADWAY");
            }
        }


        public List<T> Get<T>(T entity) where T : IROADWAY
        {
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                return conn.SelectFmt<T>("SELECT * FROM ROADWAY WHERE FACILITY = {0} AND ROADNUM ={1}", entity.FACILITY,entity.ROADNUM);
            }
        }
    }
}
