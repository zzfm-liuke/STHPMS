using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.I_DAL;

namespace ZZHMHN.DAL.Core
{
    /// <summary>
    /// 数据层接口统一基类
    /// </summary>
    public abstract class DalBase : DisposeObject, IDal
    {
        public virtual IBase.I_Core.IScene Scene
        {
            get;
            set;
        }
    }
}
