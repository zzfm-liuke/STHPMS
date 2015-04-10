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
    public class CodeInfoRepository : DalBase, ICodeInfoRepository
    {

       
        public List<T> Get<T>(T entity) where T : ICODEINFO
        {
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                return conn.SelectFmt<T>("select * from CODEINFO where STNDNAME = {0} and info != 'no data'", entity.STNDNAME);
            }
        }


        public List<int> GetMaxNum()
        {
            using (IDbConnection conn = MyApp.Dal.BasisDao.IHPMS.OpenDbConnection())
            {
                return conn.Column<int>("SELECT Max(CODE) AS MAXRNUM FROM CODEINFO WHERE STNDNAME = 'ROADWAY.ROADNUM'");
            }
        }
    }
}
