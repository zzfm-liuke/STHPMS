using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.Ihpms;

namespace ZZHMHN.IBase.I_DAL
{
    public interface ICodeInfoRepository : IDal
    {
        List<T> Get<T>(T entity) where T : ICODEINFO;

        List<int> GetMaxNum() ;
    }
}
