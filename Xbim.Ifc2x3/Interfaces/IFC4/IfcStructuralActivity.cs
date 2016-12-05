// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralActivity : IIfcStructuralActivity
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralActivity), 8)]
		IIfcStructuralLoad IIfcStructuralActivity.AppliedLoad 
		{ 
			get
			{
				return AppliedLoad;
			} 
			set
			{
				AppliedLoad = value as StructuralLoadResource.IfcStructuralLoad;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralActivity), 9)]
		Ifc4.Interfaces.IfcGlobalOrLocalEnum IIfcStructuralActivity.GlobalOrLocal 
		{ 
			get
			{
				//## Custom code to handle enumeration of GlobalOrLocal
				//##
				switch (GlobalOrLocal)
				{
					case RepresentationResource.IfcGlobalOrLocalEnum.GLOBAL_COORDS:
						return Ifc4.Interfaces.IfcGlobalOrLocalEnum.GLOBAL_COORDS;
					case RepresentationResource.IfcGlobalOrLocalEnum.LOCAL_COORDS:
						return Ifc4.Interfaces.IfcGlobalOrLocalEnum.LOCAL_COORDS;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of GlobalOrLocal
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcGlobalOrLocalEnum.GLOBAL_COORDS:
						GlobalOrLocal = RepresentationResource.IfcGlobalOrLocalEnum.GLOBAL_COORDS;
						return;
					case Ifc4.Interfaces.IfcGlobalOrLocalEnum.LOCAL_COORDS:
						GlobalOrLocal = RepresentationResource.IfcGlobalOrLocalEnum.LOCAL_COORDS;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		IEnumerable<IIfcRelConnectsStructuralActivity> IIfcStructuralActivity.AssignedToStructuralItem 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsStructuralActivity>(e => (e.RelatedStructuralActivity as IfcStructuralActivity) == this, "RelatedStructuralActivity", this);
			} 
		}
	//## Custom code
	//##
	}
}