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

namespace ZZHMHN.Web.Entity.Archive
{
	[Alias("SAMPHEADER")]
    public partial class SAMPHEADER :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.IArchive.ISAMPHEADER
    {
		public SAMPHEADER()
		{
		}

        [Required]
		[PrimaryKey]
        public int ArchID { get; set;}		
		/// <summary>
        /// length: 30
        /// </summary>
        [StringLength(30)]
        public string SAMPID { get; set;}
        public int? SEGID { get; set;}
        public DateTime? SURVDATE { get; set;}
        public double? SURVLANE { get; set;}
        public double? SBEGINPT { get; set;}
        public double? SENDPT { get; set;}
        public double? SAMPSIZE { get; set;}
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
        public double? SAMPPCI { get; set;}
        public double? SAMPPCIDEVICE { get; set;}
    }
}
#pragma warning restore 1591