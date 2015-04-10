using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity.Ihpms;

namespace ZZHMHN.IBase.I_BLL
{
    public interface IDatabaseManagerBill : IBll
    {
        string Add(It_basis_road road);
        int Update(It_basis_road road);
        int Remove(string id);
        long GetRecordCount();
        bool ExistRoad(object anonType);
        List<T> Get<T>(int k, int r) where T : class ,It_basis_road;
    }
}
