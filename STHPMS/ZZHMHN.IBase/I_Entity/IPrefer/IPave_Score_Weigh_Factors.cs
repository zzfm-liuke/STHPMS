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

namespace ZZHMHN.IBase.I_Entity.IPrefer
{
	[IAlias("Pave_Score_Weigh_Factors")]
    public partial interface IPave_Score_Weigh_Factor :ZZHMHN.IBase.I_Entity.IEntity
    {
        [Required]
		[PrimaryKey]
        short CODE { get; set;}		
        double? Cx_Coefficient { get; set;}
        double? PCI_Coefficient { get; set;}
        double? Ride_Coefficient { get; set;}
        double? FN_Coefficient { get; set;}
    }
}
#pragma warning restore 1591
