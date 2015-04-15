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
    public class PmseltsRepository : DalBase, IPmseltsRepository
    {
        public List<T> Get<T>(IPMSELT entity) where T : class, IPMSELT
        {
            string databaseId = this.Scene.Context.RoadWayDatabaseId;
            string databaseName = databaseId.GetDatbaseNameById();

            using (IRoadsDao dao = this.Scene.Dal.RoadsDao)
            {
                dao.DataSource = databaseName;
                using (IDbConnection conn = dao.IHPMS.OpenDbConnection())
                {
                    //return conn.SelectFmt<T>("SELECT * FROM PMSELTS WHERE UPDATE_MULT = -1");
                    if(entity.UPDATE_MULT != null)
                    {

                        return conn.Select<T>(q => q.UPDATE_MULT == entity.UPDATE_MULT);
                    }
                    else if (entity.STND_NAME != null)
                    {
                        return conn.Select<T>(q => q.STND_NAME == entity.STND_NAME);
                    }
                    return conn.Select<T>();
                }
            }
        }


        public List<string> GetVal_OP(string stnd_name)
        {
            string databaseId = this.Scene.Context.RoadWayDatabaseId;
            string databaseName = databaseId.GetDatbaseNameById();
            using (IRoadsDao dao = this.Scene.Dal.RoadsDao)
            {
                dao.DataSource = databaseName;
                using (IDbConnection conn = dao.IHPMS.OpenDbConnection())
                {
                    string sql = string.Format("SELECT VAL_OP1 FROM PMSELTS WHERE STND_NAME = '{0}'", stnd_name);
                    return conn.Column<string>(sql);

                }
            };
        }


        public int ExcuteSqlByIHPMS(string table, string field, string fieldValue, string RoadNum, string segIds, string begin, string end)
        {
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                string sql = string.Format( @"UPDATE {0} SET {1} = {2} WHERE SEGID IN (SELECT SEGID FROM ROADWAY INNER JOIN INVNTORY ON ROADWAY.RDWAYID = INVNTORY.RDWAYID WHERE ((ROADWAY.RoadNum = '{3}')) AND SEGID in ({4}) AND BEGINMP >= '{5}' AND ENDMP <= '{6}')",table,field,fieldValue,RoadNum,segIds,begin,end);
                return conn.ExecuteNonQuery(sql);
            }
        }
    }
}
