// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedBldgServiceElements;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelFlowControlElements
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelFlowControlElements : IIfcRelConnects
	{
		IItemSet<IIfcDistributionControlElement> @RelatedControlElements { get; }
		IIfcDistributionFlowElement @RelatingFlowElement { get;  set; }
	
	}
}

namespace Xbim.Ifc4.SharedBldgServiceElements
{
	[ExpressType("IfcRelFlowControlElements", 360)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelFlowControlElements : IfcRelConnects, IInstantiableEntity, IIfcRelFlowControlElements, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelFlowControlElements>
	{
		#region IIfcRelFlowControlElements explicit implementation
		IItemSet<IIfcDistributionControlElement> IIfcRelFlowControlElements.RelatedControlElements { 
			get { return new Common.Collections.ProxyItemSet<IfcDistributionControlElement, IIfcDistributionControlElement>( @RelatedControlElements); } 
		}	
		IIfcDistributionFlowElement IIfcRelFlowControlElements.RelatingFlowElement { 
 
 
			get { return @RelatingFlowElement; } 
			set { RelatingFlowElement = value as IfcDistributionFlowElement;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelFlowControlElements(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedControlElements = new ItemSet<IfcDistributionControlElement>( this, 0,  5);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcDistributionControlElement> _relatedControlElements;
		private IfcDistributionFlowElement _relatingFlowElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 5)]
		public IItemSet<IfcDistributionControlElement> @RelatedControlElements 
		{ 
			get 
			{
				if(_activated) return _relatedControlElements;
				Activate();
				return _relatedControlElements;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcDistributionFlowElement @RelatingFlowElement 
		{ 
			get 
			{
				if(_activated) return _relatingFlowElement;
				Activate();
				return _relatingFlowElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingFlowElement = v, _relatingFlowElement, value,  "RelatingFlowElement", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatedControlElements.InternalAdd((IfcDistributionControlElement)value.EntityVal);
					return;
				case 5: 
					_relatingFlowElement = (IfcDistributionFlowElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelFlowControlElements other)
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
				foreach(var entity in @RelatedControlElements)
					yield return entity;
				if (@RelatingFlowElement != null)
					yield return @RelatingFlowElement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedControlElements)
					yield return entity;
				if (@RelatingFlowElement != null)
					yield return @RelatingFlowElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}