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
	[Alias("sysdiagrams")]
    public partial class sysdiagram :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.Isysdiagram
    {
		public sysdiagram()
		{
		}

		/// <summary>
        /// length: 128
        /// </summary>
        [StringLength(128)]
        [Required]
        public string name { get; set;}
        [Required]
        public int principal_id { get; set;}
        [AutoIncrement]
		[PrimaryKey]
        public int diagram_id { get; set;}		
        public int? version { get; set;}
        public byte[] definition { get; set;}
    }
}
#pragma warning restore 1591
