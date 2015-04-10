using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.Ihpms;


namespace ZZHMHN.IBase.I_BLL
{
    public interface ICodeInfoBll : IBll
    {
      
        List<T> Get<T>(T entity) where T : class ,ICODEINFO;
        List<int> GetMaxNum();

        long Insert(ICODEINFO entity);
    }
}
