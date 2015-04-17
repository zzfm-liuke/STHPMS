using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ServiceStack.OrmLite;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace ZZHMHN.Web.Entity.Ihpms.View
{
    [Alias("ROADWAY_View")]
    public class ROADWAY_View : ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.IView.IROADWAY_VIEW
    {
        [Required]
        [PrimaryKey]
        public int RDWAYID { get; set; }

        /// <summary>
        /// 道路名称
        /// </summary>
        [StringLength(6)]
        public string ROAD_INFO { get; set; }

        /// <summary>
        /// 设施名称
        /// </summary>
        [StringLength(60)]
        public string FACILITY_INFO { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? BEGINDATE { get; set; }

        /// <summary>
        /// 主要方向
        /// </summary>
       [StringLength(60)]
        public string PRIMARYDIR_INFO { get; set; }

        /// <summary>
        /// 次要方向
        /// </summary>
         [StringLength(60)]
        public string SECONDDIR_INFO { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
         [StringLength(60)]
         public string COMMENTS { get; set; }
    }
}