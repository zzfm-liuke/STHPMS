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
	[Alias("SAMPDATA")]
    public partial class SAMPDATUM :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.IArchive.ISAMPDATUM
    {
		public SAMPDATUM()
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
        public double? SEGID { get; set;}
        public double? DISTID { get; set;}
        public float? QUANTLOW { get; set;}
        public float? QUANTMED { get; set;}
        public float? QUANTHI { get; set;}
        public float? QUANTNA { get; set;}
    }
}
#pragma warning restore 1591
