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
	[Alias("PREF_ITEMS")]
    public partial class PREF_ITEM :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.IPREF_ITEM
    {
		public PREF_ITEM()
		{
		}

		/// <summary>
        /// length: 30
        /// </summary>
        [StringLength(30)]
        [Required]
		[PrimaryKey]
        public string ITEM { get; set;}		
		/// <summary>
        /// length: 20
        /// </summary>
        [StringLength(20)]
        public string VALUE { get; set;}
    }
}
#pragma warning restore 1591
