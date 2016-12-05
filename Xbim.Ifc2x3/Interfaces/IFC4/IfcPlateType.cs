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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcPlateType : IIfcPlateType
	{

		[CrossSchemaAttribute(typeof(IIfcPlateType), 10)]
		Ifc4.Interfaces.IfcPlateTypeEnum IIfcPlateType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcPlateTypeEnum.CURTAIN_PANEL:
						return Ifc4.Interfaces.IfcPlateTypeEnum.CURTAIN_PANEL;
					case IfcPlateTypeEnum.SHEET:
						return Ifc4.Interfaces.IfcPlateTypeEnum.SHEET;
					case IfcPlateTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcPlateTypeEnum.USERDEFINED;
					case IfcPlateTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPlateTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcPlateTypeEnum.CURTAIN_PANEL:
						PredefinedType = IfcPlateTypeEnum.CURTAIN_PANEL;
						return;
					case Ifc4.Interfaces.IfcPlateTypeEnum.SHEET:
						PredefinedType = IfcPlateTypeEnum.SHEET;
						return;
					case Ifc4.Interfaces.IfcPlateTypeEnum.USERDEFINED:
						PredefinedType = IfcPlateTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcPlateTypeEnum.NOTDEFINED:
						PredefinedType = IfcPlateTypeEnum.NOTDEFINED;
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