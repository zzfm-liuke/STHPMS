// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ServiceStack.OrmLite;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace ZZHMHN.Web.Entity.Ihpms
{
	[Alias("PMSELTS")]
    public partial class PMSELT :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.IPMSELT
    {
		public PMSELT()
		{
		}

		/// <summary>
        /// length: 25
        /// </summary>
        [StringLength(25)]
        [Required]
		[PrimaryKey]
        public string STND_NAME { get; set;}		
        public bool? TBL_AVG { get; set;}
        public bool? TBL_MAX { get; set;}
        public bool? TBL_SUM { get; set;}
        public bool? TBL_MIN { get; set;}
		/// <summary>
        /// length: 20
        /// </summary>
        [StringLength(20)]
        public string ENGL_NAME { get; set;}
		/// <summary>
        /// length: 60
        /// </summary>
        [StringLength(60)]
        public string DEFINITION { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string TYPE { get; set;}
        public short? EDITORDER { get; set;}
		/// <summary>
        /// length: 7
        /// </summary>
        [StringLength(7)]
        public string UNITS { get; set;}
        public int? FLD_POS { get; set;}
        public int? FLD_WIDTH { get; set;}
        public float? FLD_DEC { get; set;}
        public short? UPDATE_MULT { get; set;}
		/// <summary>
        /// length: 8
        /// </summary>
        [StringLength(8)]
        public string SELCT_NDX { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string STND_SELCT { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string CSTM_SELCT { get; set;}
        public short? DCSN_TREE { get; set;}
        public double? SUM_TBL { get; set;}
		/// <summary>
        /// length: 21
        /// </summary>
        [StringLength(21)]
        public string TBL_FMT { get; set;}
		/// <summary>
        /// length: 20
        /// </summary>
        [StringLength(20)]
        public string SUM_HDG1 { get; set;}
		/// <summary>
        /// length: 20
        /// </summary>
        [StringLength(20)]
        public string SUM_HDG2 { get; set;}
		/// <summary>
        /// length: 20
        /// </summary>
        [StringLength(20)]
        public string SUM_HDG3 { get; set;}
        public int? DETAIL_TBL { get; set;}
        public int? DT_XPOS { get; set;}
        public int? DT_YPOS { get; set;}
        public int? CSTM_TBL { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string PIE { get; set;}
        [Required]
        public bool CHART_CAT { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string CHART_VAL { get; set;}
        [Required]
        public bool CHART_SER { get; set;}
        [Required]
        public bool GRAPH_X { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string GRAPH_Y { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string SORT_OPTS { get; set;}
        public short? MAPOPTIONS { get; set;}
        public int? MAPPRIMARY { get; set;}
		/// <summary>
        /// length: 8
        /// </summary>
        [StringLength(8)]
        public string MAPCOLOR { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR1_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR2_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR3_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR4_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR5_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR6_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR7_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR8_P { get; set;}
		/// <summary>
        /// length: 20
        /// </summary>
        [StringLength(20)]
        public string LTITLE2_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND1_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND2_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND3_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND4_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND5_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND6_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND7_P { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND8_P { get; set;}
        public double? MAPSECOND { get; set;}
		/// <summary>
        /// length: 4
        /// </summary>
        [StringLength(4)]
        public string MAPTHICK { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR1_S { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR2_S { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR3_S { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string ATTR4_S { get; set;}
		/// <summary>
        /// length: 20
        /// </summary>
        [StringLength(20)]
        public string LTITLE2_S { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND1_S { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND2_S { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND3_S { get; set;}
		/// <summary>
        /// length: 15
        /// </summary>
        [StringLength(15)]
        public string LEGEND4_S { get; set;}
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        public string VAL_OP1 { get; set;}
		/// <summary>
        /// length: 19
        /// </summary>
        [StringLength(19)]
        public string VAL_ARG1 { get; set;}
        public int? INFOLENGTH { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string VAL_LOG_OP { get; set;}
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        public string VAL_OP2 { get; set;}
		/// <summary>
        /// length: 19
        /// </summary>
        [StringLength(19)]
        public string VAL_ARG2 { get; set;}
		/// <summary>
        /// length: 40
        /// </summary>
        [StringLength(40)]
        public string COMMENTS { get; set;}
        public DateTime? REVDATE { get; set;}
    }
}
#pragma warning restore 1591
