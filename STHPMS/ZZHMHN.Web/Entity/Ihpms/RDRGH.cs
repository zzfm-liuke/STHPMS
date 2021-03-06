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
	[Alias("RDRGH")]
    public partial class RDRGH :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.IRDRGH
    {
		public RDRGH()
		{
		}

        [Required]
		[PrimaryKey]
        public int SEGID { get; set;}		
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        public string DEVICE { get; set;}
        public int? IRIMAX { get; set;}
        public int? IRIMEAN { get; set;}
        public float? IRIMIN { get; set;}
        public float? IRISTDDEV { get; set;}
        public DateTime? RGHDATE { get; set;}
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        public string RGHLANE { get; set;}
        public float? RGHMAX { get; set;}
        public int? RGHMEAN { get; set;}
        public float? RGHMIN { get; set;}
        public float? RGHSTDDEV { get; set;}
        public float? RUTMEAN { get; set;}
    }
}
#pragma warning restore 1591
