using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.Ihpms;

namespace ZZHMHN.IBase.I_BLL
{
    public interface IRoadWayBill : IBll
    {
        long Insert(IROADWAY entity);
        long Update(IROADWAY entity);
        long Del(IROADWAY entiy);
        List<int> GetMaxNum();
        List<T> Get<T>(T entity) where T : class ,IROADWAY;

        long GetRecordCount();
        List<T> Get<T>(int k, int r) where T : class ,I_Entity.IView.IROADWAY_VIEW;
    }
}
