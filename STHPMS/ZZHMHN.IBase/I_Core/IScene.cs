using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.IBase.I_UI;

namespace ZZHMHN.IBase.I_Core
{
    /// <summary>
    /// 场景：有调用逻辑的处理单元
    /// </summary>
    public interface IScene : IDisposable
    {
        IContext Context { get; set; }
        IUIFacade UI { get; }
        IBllFacade Bll { get; }
        IDalFacade Dal { get; }
    }
}
