using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_Core
{
    /// <summary>
    /// 模块统一接口
    /// </summary>
    public interface IModule:IDisposable
    {
        /// <summary>
        /// 初始化操作
        /// </summary>
        void Init();
    }
}
