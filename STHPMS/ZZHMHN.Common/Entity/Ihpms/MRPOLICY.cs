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
	[Alias("MRPOLICY")]
    public partial class MRPOLICY :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.IMRPOLICY
    {
		public MRPOLICY()
		{
		}

        [Required]
		[PrimaryKey]
        public int BRANCH { get; set;}		
        public int? SET_ID { get; set;}
		/// <summary>
        /// length: 50
        /// </summary>
        [StringLength(50)]
        public string ACTV_ASSN { get; set;}
    }
}
#pragma warning restore 1591