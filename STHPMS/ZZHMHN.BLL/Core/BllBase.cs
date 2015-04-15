using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.I_BLL;

namespace ZZHMHN.BLL.Core
{
    /// <summary>
    /// 业务层接口统一基类
    /// </summary>
    public abstract class BllBase:DisposeObject,IBll
    {
        public virtual IBase.I_Core.IScene Scene
        {
            get;
            set;
        }
    }
}
