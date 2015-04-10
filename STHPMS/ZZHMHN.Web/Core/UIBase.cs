using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.I_UI;

namespace ZZHMHN.Web.Core
{
    /// <summary>
    /// ui层接口统一基类
    /// </summary>
    public abstract class UIBase : DisposeObject, IUI
    {
        public virtual IBase.I_Core.IScene Scene
        {
            get;
            set;
        }
    }
}
