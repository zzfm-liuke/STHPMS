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
    public  class RoadWayBussiness : BllBase, IRoadWayBill
    {

        public long Insert(IROADWAY entity)
        {
            return MyApp.Dal.BasisDao.IHPMS.Insert(entity);
        }


        public List<int> GetMaxNum()
        {
            return MyApp.Dal.RoadWayRepository.GetMaxNum();
        }


        public List<T> Get<T>(T entity) where T : class, IROADWAY
        {
            return MyApp.Dal.RoadWayRepository.Get<T>(entity);
        }

        public long GetRecordCount()
        {
            return MyApp.Dal.BasisDao.IHPMS.Count<IBase.I_Entity.IView.IROADWAY_VIEW>();
        }

        public List<T> Get<T>(int k, int r) where T : class, IBase.I_Entity.IView.IROADWAY_VIEW
        {
            return MyApp.Dal.BasisDao.IHPMS.Select<T>(q => q.OrderBy(x => x.RDWAYID).Limit(skip: k, rows: r));
        }


        public long Update(IROADWAY entity)
        {
            return MyApp.Dal.BasisDao.IHPMS.Update<IROADWAY>(entity);
        }

        public long Del(IROADWAY entiy)
        {
            return MyApp.Dal.BasisDao.IHPMS.Delete<IROADWAY>(new { RDWAYID = entiy.RDWAYID });
        }
    }
}
