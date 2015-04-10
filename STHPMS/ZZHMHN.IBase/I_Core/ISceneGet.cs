using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_Core
{
    /// <summary>
    /// 场景获取接口
    /// </summary>
    public interface ISceneGet
    {
        /// <summary>
        /// 场景对象
        /// </summary>
        IScene Scene { get; set; }
    }
}
