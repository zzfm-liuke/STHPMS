// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using ServiceStack.OrmLite;
using ServiceStack.DataAnnotations;
using ServiceStack.Model;
using ZZHMHN.IBase.I_Entity;

namespace ZZHMHN.IBase.I_Entity.Ihpms
{
	[IAlias("RDTRF")]
    public partial interface IRDTRF :ZZHMHN.IBase.I_Entity.IEntity
    {
        [Required]
		[PrimaryKey]
        int SEGID { get; set;}		
        int? CURADT { get; set;}
        int? CURADTYEAR { get; set;}
        float? DIRSPLTPCT { get; set;}
        float? GROWTHRATE { get; set;}
        float? TRKPCTAADT { get; set;}
        float? TRKWTPAT { get; set;}
		/// <summary>
        /// length: 50
        /// </summary>
        [StringLength(50)]
        string COMMENTS { get; set;}
    }
}
#pragma warning restore 1591
