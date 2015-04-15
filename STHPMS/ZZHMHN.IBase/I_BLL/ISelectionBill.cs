using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Entity;
using ZZHMHN.IBase.I_Entity.ISelect;

namespace ZZHMHN.IBase.I_BLL 
{
    public interface ISelectionBill : IBll
    {
        List<T> Get<T>() where T : class , ISelection;
    }
}
