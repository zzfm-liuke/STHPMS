using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity.ISelect;

namespace ZZHMHN.IBase.I_DAL
{
    public interface ISelectionRepository : IDal
    {
        List<T> Get<T>() where T : class , ISelection;
    }
}
