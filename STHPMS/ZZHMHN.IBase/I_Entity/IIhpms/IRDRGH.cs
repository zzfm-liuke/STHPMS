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
	[IAlias("RDRGH")]
    public partial interface IRDRGH :ZZHMHN.IBase.I_Entity.IEntity
    {
        [Required]
		[PrimaryKey]
        int SEGID { get; set;}		
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        string DEVICE { get; set;}
        int? IRIMAX { get; set;}
        int? IRIMEAN { get; set;}
        float? IRIMIN { get; set;}
        float? IRISTDDEV { get; set;}
        DateTime? RGHDATE { get; set;}
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        string RGHLANE { get; set;}
        float? RGHMAX { get; set;}
        int? RGHMEAN { get; set;}
        float? RGHMIN { get; set;}
        float? RGHSTDDEV { get; set;}
        float? RUTMEAN { get; set;}
    }
}
#pragma warning restore 1591
