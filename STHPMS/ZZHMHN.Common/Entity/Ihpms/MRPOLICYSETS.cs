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
	[Alias("MRPOLICYSETS")]
    public partial class MRPOLICYSET :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.IMRPOLICYSET
    {
		public MRPOLICYSET()
		{
		}

        [Required]
		[PrimaryKey]
        public int SET_ID { get; set;}		
		/// <summary>
        /// length: 50
        /// </summary>
        [StringLength(50)]
        public string SET_NAME { get; set;}
        [Required]
        public bool SELECTED { get; set;}
    }
}
#pragma warning restore 1591