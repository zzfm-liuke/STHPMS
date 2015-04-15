using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.Ihpms;

namespace ZZHMHN.IBase.I_BLL
{
    public interface IRdLayBill : IBll
    {
        List<T> GetMaxLayNum<T>(string RoadNum, string segIds, string begin, string end) where T : class ,IRDLAY;

        List<T> Get<T>() where T : class ,IRDLAY;

        List<T> GetRdLay<T>(string where) where T : class ,IRDLAY;

        int Delete(IRDLAY entity);

        int Update(IRDLAY entity);

        long Insert(IRDLAY entity);
    }
}
