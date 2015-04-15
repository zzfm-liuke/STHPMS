using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.BLL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Entity.ISelect;


namespace ZZHMHN.BLL.Bussiness
{
    public class SelectionBussiness : BllBase, ISelectionBill
    {
        public List<T> Get<T>() where T : class, ISelection
        {
           //来自用户库
            return this.Scene.Dal.SelectionRepository.Get<T>();
        }
    }
}
