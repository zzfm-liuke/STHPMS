using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.IBase.I_UI
{
    /// <summary>
    /// 界面层接口调用统一出口
    /// </summary>
    public interface IUIFacade : IFacade
    {
        ITestUI Test { get;}
    }
}
