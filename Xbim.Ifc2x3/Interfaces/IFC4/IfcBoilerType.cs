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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcBoilerType : IIfcBoilerType
	{

		[CrossSchemaAttribute(typeof(IIfcBoilerType), 10)]
		Ifc4.Interfaces.IfcBoilerTypeEnum IIfcBoilerType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcBoilerTypeEnum.WATER:
						return Ifc4.Interfaces.IfcBoilerTypeEnum.WATER;
					case IfcBoilerTypeEnum.STEAM:
						return Ifc4.Interfaces.IfcBoilerTypeEnum.STEAM;
					case IfcBoilerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcBoilerTypeEnum.USERDEFINED;
					case IfcBoilerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcBoilerTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcBoilerTypeEnum.WATER:
						PredefinedType = IfcBoilerTypeEnum.WATER;
						return;
					case Ifc4.Interfaces.IfcBoilerTypeEnum.STEAM:
						PredefinedType = IfcBoilerTypeEnum.STEAM;
						return;
					case Ifc4.Interfaces.IfcBoilerTypeEnum.USERDEFINED:
						PredefinedType = IfcBoilerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcBoilerTypeEnum.NOTDEFINED:
						PredefinedType = IfcBoilerTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}