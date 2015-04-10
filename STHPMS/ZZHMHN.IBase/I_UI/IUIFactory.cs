using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.IBase.I_UI
{
    /// <summary>
    /// UI 对象创建工厂类
    /// </summary>
    public interface IUIFactory : IObjectFactory
    {
        ITestUI GetTestUI();
        void DisposeTestUI();
    }
}
