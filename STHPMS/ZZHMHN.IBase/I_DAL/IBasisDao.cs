using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_DAL
{
    /// <summary>
    /// 基础数据库访问
    /// </summary>
    public interface IBasisDao : IDal
    {
        /// <summary>
        /// Archive数据库访问
        /// </summary>
        IRepository Archive { get; }
        /// <summary>
        /// IHPMS数据库访问
        /// </summary>
        IRepository IHPMS { get; }
        /// <summary>
        /// PCIWCI数据库访问
        /// </summary>
        IRepository PCIWCI { get; }
        /// <summary>
        /// Prefer数据库访问
        /// </summary>
        IRepository Prefer { get; }
        /// <summary>
        /// Select数据库访问
        /// </summary>
        IRepository Select { get; }
    }
}
