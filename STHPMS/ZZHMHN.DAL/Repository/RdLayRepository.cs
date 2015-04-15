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
    public class RdLayRepository : DalBase, IRdLayRepository
    {
        public List<T> GetMaxLayNum<T>(string RoadNum, string segIds, string begin, string end) where T : class, IRDLAY
        {
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                string sql = string.Format(@"SELECT SEGID, MAX(LAYERNUM) AS LAYERNUM FROM RDLAY WHERE SEGID IN (SELECT SEGID FROM ROADWAY INNER JOIN INVNTORY ON ROADWAY.RDWAYID = INVNTORY.RDWAYID WHERE ((ROADWAY.RoadNum = '{0}')) AND SEGID in ({1}) AND BEGINMP >= '{2}' AND ENDMP <= '{3}') GROUP BY SEGID", RoadNum, segIds, begin, end);
                return conn.SelectFmt<T>(sql);
            }
        }



        public List<T> GetRdLay<T>(string where) where T : class, IRDLAY
        {
             using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                string sql = string.Format("select segid,LAYERNUM,LAYERTHICK from RDLAY where {0}",where);
                return conn.SelectFmt<T>(sql);
            }
        }
    }
}
