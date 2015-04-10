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
	[Alias("CODEINFO")]
    public partial class CODEINFO :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.ICODEINFO
    {
		public CODEINFO()
		{
		}

		/// <summary>
        /// length: 19
        /// </summary>
        [StringLength(19)]
        [Required]
		[PrimaryKey]
        public string STNDNAME { get; set;}		
        [Required]
		[PrimaryKey]
        public int CODE { get; set;}		
		/// <summary>
        /// length: 60
        /// </summary>
        [StringLength(60)]
        public string INFO { get; set;}
		/// <summary>
        /// length: 30
        /// </summary>
        [StringLength(30)]
        public string LIMITINFO { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string CHECKED { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string CATCHK { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string MENUCHECK { get; set;}
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string ACTIVE { get; set;}
		/// <summary>
        /// length: 19
        /// </summary>
        [StringLength(19)]
        public string STDNAME { get; set;}
		/// <summary>
        /// length: 25
        /// </summary>
        [StringLength(25)]
        public string CATTITLE { get; set;}
    }
}
#pragma warning restore 1591
