using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.BLL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Entity.Ihpms;

namespace ZZHMHN.BLL.Bussiness
{
    public class RdLayBussiness : BllBase,IRdLayBill
    {
        public List<T> GetMaxLayNum<T>(string RoadNum, string segIds, string begin, string end) where T : class, IRDLAY
        {
            return MyApp.Dal.RdLayRepository.GetMaxLayNum<T>(RoadNum, segIds, begin, end);
        }


        public List<T> Get<T>() where T : class, IRDLAY
        {
            return MyApp.Dal.BasisDao.IHPMS.Select<T>();
        }


        public List<T> GetRdLay<T>(string where) where T : class, IRDLAY
        {
            return MyApp.Dal.RdLayRepository.GetRdLay<T>(where);
        }


        public int Delete(IRDLAY entity)
        {
            return MyApp.Dal.BasisDao.IHPMS.Delete<IRDLAY>(new { SEGID=entity.SEGID , LAYERNUM=entity.LAYERNUM });
        }

        public int Update(IRDLAY entity)
        {
            return MyApp.Dal.BasisDao.IHPMS.Update<IRDLAY>(new { LAYERTHICK = entity.LAYERTHICK },p=>p.SEGID==entity.SEGID && p.LAYERNUM==entity.LAYERNUM);
        }


        public long Insert(IRDLAY entity)
        {
            return MyApp.Dal.BasisDao.IHPMS.Insert<IRDLAY>(entity);
        }
    }
}
