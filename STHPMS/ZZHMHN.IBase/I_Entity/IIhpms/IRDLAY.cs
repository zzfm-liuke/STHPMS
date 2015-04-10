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
	[IAlias("RDLAY")]
    public partial interface IRDLAY :ZZHMHN.IBase.I_Entity.IEntity
    {
        [Required]
		[PrimaryKey]
        int SEGID { get; set;}		
        [Required]
		[PrimaryKey]
        float LAYERNUM { get; set;}		
        short? LAYERCODE { get; set;}
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        string LAYERTYPE { get; set;}
        float? LAYERTHICK { get; set;}
        float? LAYERM { get; set;}
		/// <summary>
        /// length: 10
        /// </summary>
        [StringLength(10)]
        string MTRLTYPE { get; set;}
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        string ASPHTYPE { get; set;}
		/// <summary>
        /// length: 2
        /// </summary>
        [StringLength(2)]
        string STRGTHTYPE { get; set;}
        float? STRGTHVAL { get; set;}
        short? STRGTHYEAR { get; set;}
        short? CONSTYEAR { get; set;}
		/// <summary>
        /// length: 60
        /// </summary>
        [StringLength(60)]
        string COMMENTS { get; set;}
        DateTime? REVDATE { get; set;}
		/// <summary>
        /// length: 10
        /// </summary>
        [StringLength(10)]
        string FILENUM { get; set;}
    }
}
#pragma warning restore 1591