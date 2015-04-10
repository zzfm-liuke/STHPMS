using System;
using ServiceStack.OrmLite;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;
using ZZHMHN.IBase.I_Entity;

namespace ZZHMHN.IBase.I_Entity.IView
{
    [IAlias("ROADWAY_View")]
    public interface IROADWAY_VIEW : ZZHMHN.IBase.I_Entity.IEntity
    {
        [Required]
        [PrimaryKey]
         int RDWAYID { get; set; }

        /// <summary>
        /// 道路名称
        /// </summary>
        [StringLength(6)]
        string ROAD_INFO { get; set; }

        /// <summary>
        /// 设施名称
        /// </summary>
        [StringLength(60)]
         string FACILITY_INFO { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
         DateTime? BEGINDATE { get; set; }

        /// <summary>
        /// 主要方向
        /// </summary>
        [StringLength(60)]
         string PRIMARYDIR_INFO { get; set; }

        /// <summary>
        /// 次要方向
        /// </summary>
        [StringLength(60)]
         string SECONDDIR_INFO { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(60)]
         string COMMENTS { get; set; }
    }
}
