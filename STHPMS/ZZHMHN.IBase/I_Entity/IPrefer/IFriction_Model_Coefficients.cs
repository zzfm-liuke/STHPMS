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
	[IAlias("Friction_Model_Coefficients")]
    public partial interface IFriction_Model_Coefficient :ZZHMHN.IBase.I_Entity.IEntity
    {
        [Required]
		[PrimaryKey]
        short CODE { get; set;}		
        int? Method { get; set;}
        bool? SelectedOption { get; set;}
        double? Fri_Coefficient_a0 { get; set;}
        double? Fri_Coefficient_a1 { get; set;}
        double? Fri_Coefficient_a2 { get; set;}
        double? Fri_Coefficient_a3 { get; set;}
    }
}
#pragma warning restore 1591
