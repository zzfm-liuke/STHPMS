using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_Core
{
    /// <summary>
    /// 调用逻辑上下文
    /// </summary>
    public interface IContext
    {
        /// <summary>
        /// 用户id
        /// </summary>
        string UserId { get;  }
        /// <summary>
        /// 路网数据库Id
        /// </summary>
        string RoadWayDatabaseId { get; }
    }
}
