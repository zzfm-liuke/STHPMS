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
	[IAlias("Traffic_Parameters")]
    public partial interface ITraffic_Parameter :ZZHMHN.IBase.I_Entity.IEntity
    {
        double? Lane_Factor { get; set;}
        short? Truck_Pattern { get; set;}
        double? Equi_18Kip_Load { get; set;}
    }
}
#pragma warning restore 1591
