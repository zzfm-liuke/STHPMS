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
	[IAlias("Road & Stations")]
    public partial interface IRoad___Station :ZZHMHN.IBase.I_Entity.IEntity
    {
		/// <summary>
        /// length: 1
        /// </summary>
        [StringLength(1)]
        string Facility { get; set;}
        [Alias("Road Name")]
        double? Road_Name { get; set;}
        [Alias("Begin St")]
        double? Begin_St { get; set;}
        [Alias("End St")]
        double? End_St { get; set;}
    }
}
#pragma warning restore 1591
