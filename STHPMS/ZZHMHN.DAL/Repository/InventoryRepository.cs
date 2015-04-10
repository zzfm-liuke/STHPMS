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
        public List<T> GetBegin<T>(int RoadNum, int rdSelectedIndex) where T : class, IINVNTORY
        {
            string tempSEGID = "select 1 union select 2 union select 3 union select 4"; //应该来自用户数据库的Select.MDB ==> SELECT SEGID FROM SELECTION IN '" & WDBPath$ & "SELECT.MDB'
            string tempSql = "";
            if (rdSelectedIndex == 0)
            {
                tempSql = @"SELECT INVNTORY.BEGINMP AS NAME, INVNTORY.BEGINMP AS DATA FROM ROADWAY INNER JOIN INVNTORY ON ROADWAY.RDWAYID = INVNTORY.RDWAYID
                        Where (ROADWAY.RoadNum = {0}) 
                        AND SEGID = ANY ({1}) ORDER BY BEGINMP, ENDMP"; 

            }
            else if (rdSelectedIndex == 1)
            {
                tempSql = @"SELECT  INVNTORY.FROMLOC AS NAME, INVNTORY.BEGINMP AS DATA FROM ROADWAY INNER JOIN INVNTORY ON ROADWAY.RDWAYID = INVNTORY.RDWAYID 
                        Where (ROADWAY.RoadNum = {0}) 
                        AND SEGID  = ANY ({1}) ORDER BY BEGINMP, ENDMP";
            }
            //基础库和用户库的联查
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                string sql = string.Format(tempSql, RoadNum, tempSEGID);
                return conn.Select<T>(sql);
            }
        }


        public List<T> GetEnd<T>(int RoadNum, string beginDrowDownList) where T : class, IINVNTORY
        {
            string tempSql = "";

            tempSql = @"SELECT INVNTORY.ENDMP AS NAME, INVNTORY.ENDMP AS DATA FROM ROADWAY INNER JOIN INVNTORY ON ROADWAY.RDWAYID = INVNTORY.RDWAYID
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
