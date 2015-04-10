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
	[IAlias("Ride_Model_Coefficient")]
    public partial interface IRide_Model_Coefficient :ZZHMHN.IBase.I_Entity.IEntity
    {
        [Required]
		[PrimaryKey]
        short Method { get; set;}		
        [Required]
		[PrimaryKey]
        short PavementCODE { get; set;}		
        [Required]
		[PrimaryKey]
        short FunctionalCODE { get; set;}		
        int? SelectedOption { get; set;}
        double? Low_ESAL_a0 { get; set;}
        double? Low_ESAL_a1 { get; set;}
        double? Low_ESAL_a2 { get; set;}
        double? Low_ESAL_a3 { get; set;}
        double? Medium_ESAL_a0 { get; set;}
        double? Medium_ESAL_a1 { get; set;}
        double? Medium_ESAL_a2 { get; set;}
        double? Medium_ESAL_a3 { get; set;}
        double? High_ESAL_a0 { get; set;}
        double? High_ESAL_a1 { get; set;}
        double? High_ESAL_a2 { get; set;}
        double? High_ESAL_a3 { get; set;}
    }
}
#pragma warning restore 1591
