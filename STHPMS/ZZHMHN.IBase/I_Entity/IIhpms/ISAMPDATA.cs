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
	[IAlias("SAMPDATA")]
    public partial interface ISAMPDATUM :ZZHMHN.IBase.I_Entity.IEntity
    {
		/// <summary>
        /// length: 30
        /// </summary>
        [StringLength(30)]
        [Required]
		[PrimaryKey]
        string SAMPID { get; set;}		
        [Required]
		[PrimaryKey]
        short SEGID { get; set;}		
        [Required]
		[PrimaryKey]
        short DISTID { get; set;}		
        short? QUANTLOW { get; set;}
        short? QUANTMED { get; set;}
        short? QUANTHI { get; set;}
        short? QUANTNA { get; set;}
    }
}
#pragma warning restore 1591
