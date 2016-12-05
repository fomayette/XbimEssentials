// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGridPlacement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGridPlacement : IIfcObjectPlacement
	{
		IIfcVirtualGridIntersection @PlacementLocation { get;  set; }
		IIfcGridPlacementDirectionSelect @PlacementRefDirection { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcGridPlacement", 439)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGridPlacement : IfcObjectPlacement, IInstantiableEntity, IIfcGridPlacement, IContainsEntityReferences, IEquatable<@IfcGridPlacement>
	{
		#region IIfcGridPlacement explicit implementation
		IIfcVirtualGridIntersection IIfcGridPlacement.PlacementLocation { 
 
 
			get { return @PlacementLocation; } 
			set { PlacementLocation = value as IfcVirtualGridIntersection;}
		}	
		IIfcGridPlacementDirectionSelect IIfcGridPlacement.PlacementRefDirection { 
 
 
			get { return @PlacementRefDirection; } 
			set { PlacementRefDirection = value as IfcGridPlacementDirectionSelect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGridPlacement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcVirtualGridIntersection _placementLocation;
		private IfcGridPlacementDirectionSelect _placementRefDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcVirtualGridIntersection @PlacementLocation 
		{ 
			get 
			{
				if(_activated) return _placementLocation;
				Activate();
				return _placementLocation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _placementLocation = v, _placementLocation, value,  "PlacementLocation", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcGridPlacementDirectionSelect @PlacementRefDirection 
		{ 
			get 
			{
				if(_activated) return _placementRefDirection;
				Activate();
				return _placementRefDirection;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _placementRefDirection = v, _placementRefDirection, value,  "PlacementRefDirection", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_placementLocation = (IfcVirtualGridIntersection)(value.EntityVal);
					return;
				case 1: 
					_placementRefDirection = (IfcGridPlacementDirectionSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGridPlacement other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@PlacementLocation != null)
					yield return @PlacementLocation;
				if (@PlacementRefDirection != null)
					yield return @PlacementRefDirection;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}