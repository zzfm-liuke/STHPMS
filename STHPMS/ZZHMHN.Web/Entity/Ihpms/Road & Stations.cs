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
	[Alias("Road & Stations")]
    public partial class Road___Station :ZZHMHN.Web.Core.EntityBase, ZZHMHN.IBase.I_Entity.Ihpms.IRoad___Station
    {
		public Road___Station()
		{
		}

		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        public string Facility { get; set;}
        [Alias("Road Name")]
        public double? Road_Name { get; set;}
        [Alias("Begin St")]
        public double? Begin_St { get; set;}
        [Alias("End St")]
        public double? End_St { get; set;}
    }
}
#pragma warning restore 1591
