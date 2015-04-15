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
    public class InventoryRepository : DalBase, IInventoryRepository
    {
        public List<T> GetBegin<T>(int RoadNum, string segIDs) where T : class, IINVNTORY
        {
            //应该来自用户数据库的Select.MDB ==> SELECT SEGID FROM SELECTION IN '" & WDBPath$ & "SELECT.MDB'
            string tempSql = "";
                tempSql = @"SELECT INVNTORY.FROMLOC ,INVNTORY.BEGINMP FROM ROADWAY INNER JOIN INVNTORY ON ROADWAY.RDWAYID = INVNTORY.RDWAYID
                        Where (ROADWAY.RoadNum = {0}) 
                        AND SEGID in ({1}) ORDER BY BEGINMP, ENDMP"; 

            //基础库和用户库的联查
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                string sql = string.Format(tempSql, RoadNum, segIDs==""?null:segIDs);
                return conn.Select<T>(sql);
            }
        }


        public List<T> GetEnd<T>(int RoadNum, string beginDrowDownList) where T : class, IINVNTORY
        {
            string tempSql = "";

            tempSql = @"SELECT INVNTORY.TOLOC , INVNTORY.ENDMP  FROM ROADWAY INNER JOIN INVNTORY ON ROADWAY.RDWAYID = INVNTORY.RDWAYID
                        Where (ROADWAY.RoadNum = {0})
                        AND INVNTORY.BEGINMP >= '{1}' ORDER BY BEGINMP, ENDMP";

            //基础库
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                string sql = string.Format(tempSql, RoadNum, beginDrowDownList);
                return conn.Select<T>(sql);
            }
        }
    }
}
