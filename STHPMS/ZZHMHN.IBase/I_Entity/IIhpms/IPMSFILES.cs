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
	[IAlias("PMSFILES")]
    public partial interface IPMSFILE :ZZHMHN.IBase.I_Entity.IEntity
    {
		/// <summary>
        /// length: 12
        /// </summary>
        [StringLength(12)]
        [Required]
		[PrimaryKey]
        string FILE_NAME { get; set;}		
		/// <summary>
        /// length: 50
        /// </summary>
        [StringLength(50)]
        string DB_Name { get; set;}
		/// <summary>
        /// length: 254
        /// </summary>
        [StringLength(254)]
        string DESCRPTION { get; set;}
        bool? DBLIST { get; set;}
        bool? MDB { get; set;}
        bool? PART_MDB { get; set;}
		/// <summary>
        /// length: 254
        /// </summary>
        [StringLength(254)]
        string COMMENTS { get; set;}
        DateTime? REV_DATE { get; set;}
    }
}
#pragma warning restore 1591
