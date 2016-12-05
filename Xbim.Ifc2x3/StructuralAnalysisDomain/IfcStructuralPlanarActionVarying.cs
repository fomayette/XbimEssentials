// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.StructuralLoadResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralPlanarActionVarying
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralPlanarActionVarying : IIfcStructuralPlanarAction
	{
		IIfcShapeAspect @VaryingAppliedLoadLocation { get;  set; }
		IItemSet<IIfcStructuralLoad> @SubsequentAppliedLoads { get; }
		List<IfcStructuralLoad> @VaryingAppliedLoads  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IfcStructuralPlanarActionVarying", 357)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralPlanarActionVarying : IfcStructuralPlanarAction, IInstantiableEntity, IIfcStructuralPlanarActionVarying, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcStructuralPlanarActionVarying>
	{
		#region IIfcStructuralPlanarActionVarying explicit implementation
		IIfcShapeAspect IIfcStructuralPlanarActionVarying.VaryingAppliedLoadLocation { 
 
 
			get { return @VaryingAppliedLoadLocation; } 
			set { VaryingAppliedLoadLocation = value as IfcShapeAspect;}
		}	
		IItemSet<IIfcStructuralLoad> IIfcStructuralPlanarActionVarying.SubsequentAppliedLoads { 
			get { return new Common.Collections.ProxyItemSet<IfcStructuralLoad, IIfcStructuralLoad>( @SubsequentAppliedLoads); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralPlanarActionVarying(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_subsequentAppliedLoads = new ItemSet<IfcStructuralLoad>( this, 0,  14);
		}

		#region Explicit attribute fields
		private IfcShapeAspect _varyingAppliedLoadLocation;
		private readonly ItemSet<IfcStructuralLoad> _subsequentAppliedLoads;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcShapeAspect @VaryingAppliedLoadLocation 
		{ 
			get 
			{
				if(_activated) return _varyingAppliedLoadLocation;
				Activate();
				return _varyingAppliedLoadLocation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _varyingAppliedLoadLocation = v, _varyingAppliedLoadLocation, value,  "VaryingAppliedLoadLocation", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1, 21)]
		public IItemSet<IfcStructuralLoad> @SubsequentAppliedLoads 
		{ 
			get 
			{
				if(_activated) return _subsequentAppliedLoads;
				Activate();
				return _subsequentAppliedLoads;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.List, EntityAttributeType.Class, 3, -1, 0)]
		public List<IfcStructuralLoad> @VaryingAppliedLoads 
		{
			get 
			{
				//## Getter for VaryingAppliedLoads
				var result = new List<IfcStructuralLoad>{AppliedLoad};
                result.AddRange(SubsequentAppliedLoads);
			    return result;
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 12: 
					_varyingAppliedLoadLocation = (IfcShapeAspect)(value.EntityVal);
					return;
				case 13: 
					_subsequentAppliedLoads.InternalAdd((IfcStructuralLoad)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralPlanarActionVarying other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				if (@AppliedLoad != null)
					yield return @AppliedLoad;
				if (@CausedBy != null)
					yield return @CausedBy;
				if (@VaryingAppliedLoadLocation != null)
					yield return @VaryingAppliedLoadLocation;
				foreach(var entity in @SubsequentAppliedLoads)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				if (@CausedBy != null)
					yield return @CausedBy;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}