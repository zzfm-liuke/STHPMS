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
	[Alias("ACTIVITY")]
    public partial class ACTIVITY :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.IACTIVITY
    {
		public ACTIVITY()
		{
		}

        [Alias("ACTIVITY")]
        [AutoIncrement]
		[PrimaryKey]
        public decimal _ACTIVITY { get; set;}		
        public int? SET_ID { get; set;}
        public decimal? COST { get; set;}
		/// <summary>
        /// length: 255
        /// </summary>
        [StringLength(255)]
        public string DESCRIPT { get; set;}
        public float? ADJFACTOR { get; set;}
    }
}
#pragma warning restore 1591
