using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_DAL
{
    /// <summary>
    /// 路网数据库访问
    /// </summary>
    public interface IRoadsDao : IDal
    {
        /// <summary>
        /// IHPMS数据库访问
        /// </summary>
        IRepository IHPMS { get; }
        /// <summary>
        /// Prefer数据库访问
        /// </summary>
        IRepository Prefer { get; }
        /// <summary>
        /// Select数据库访问
        /// </summary>
        IRepository Select { get; }
        /// <summary>
        /// 数据源后称
        /// </summary>
        string DataSource { get; set; }
    }
}
