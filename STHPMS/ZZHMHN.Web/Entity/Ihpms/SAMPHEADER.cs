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
	[Alias("SAMPHEADER")]
    public partial class SAMPHEADER :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.ISAMPHEADER
    {
		public SAMPHEADER()
		{
		}

		/// <summary>
        /// length: 30
        /// </summary>
        [StringLength(30)]
        [Required]
		[PrimaryKey]
        public string SAMPID { get; set;}		
        [Required]
		[PrimaryKey]
        public int SEGID { get; set;}		
        public DateTime? SURVDATE { get; set;}
        public short? SURVLANE { get; set;}
        public float? SBEGINPT { get; set;}
        public float? SENDPT { get; set;}
        public int? SAMPSIZE { get; set;}
		/// <summary>
        /// length: 20
        /// </summary>
        [StringLength(20)]
        public string SURVINIT { get; set;}
		/// <summary>
        /// length: 120
        /// </summary>
        [StringLength(120)]
        public string COMMENTS { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string SAMPUNITTYPE { get; set;}
        public int? SAMPPCI { get; set;}
		/// <summary>
        /// length: 50
        /// </summary>
        [StringLength(50)]
        public string SAMPPCIDEVICE { get; set;}
    }
}
#pragma warning restore 1591
