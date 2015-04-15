using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.IBase.I_DAL
{
    /// <summary>
    /// 数据层接口统一基类
    /// </summary>
    public interface IDal : ISceneGet, IDisposable
    {
    }
}
