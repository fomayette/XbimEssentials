// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConstraintAggregationRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConstraintAggregationRelationship : IPersistEntity
	{
		IfcLabel? @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IIfcConstraint @RelatingConstraint { get;  set; }
		IItemSet<IIfcConstraint> @RelatedConstraints { get; }
		IfcLogicalOperatorEnum @LogicalAggregator { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ConstraintResource
{
	[ExpressType("IfcConstraintAggregationRelationship", 82)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConstraintAggregationRelationship : PersistEntity, IInstantiableEntity, IIfcConstraintAggregationRelationship, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcConstraintAggregationRelationship>
	{
		#region IIfcConstraintAggregationRelationship explicit implementation
		IfcLabel? IIfcConstraintAggregationRelationship.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcConstraintAggregationRelationship.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IIfcConstraint IIfcConstraintAggregationRelationship.RelatingConstraint { 
 
 
			get { return @RelatingConstraint; } 
			set { RelatingConstraint = value as IfcConstraint;}
		}	
		IItemSet<IIfcConstraint> IIfcConstraintAggregationRelationship.RelatedConstraints { 
			get { return new Common.Collections.ProxyItemSet<IfcConstraint, IIfcConstraint>( @RelatedConstraints); } 
		}	
		IfcLogicalOperatorEnum IIfcConstraintAggregationRelationship.LogicalAggregator { 
 
			get { return @LogicalAggregator; } 
			set { LogicalAggregator = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstraintAggregationRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedConstraints = new ItemSet<IfcConstraint>( this, 0,  4);
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcConstraint _relatingConstraint;
		private readonly ItemSet<IfcConstraint> _relatedConstraints;
		private IfcLogicalOperatorEnum _logicalAggregator;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcConstraint @RelatingConstraint 
		{ 
			get 
			{
				if(_activated) return _relatingConstraint;
				Activate();
				return _relatingConstraint;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingConstraint = v, _relatingConstraint, value,  "RelatingConstraint", 3);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 4)]
		public IItemSet<IfcConstraint> @RelatedConstraints 
		{ 
			get 
			{
				if(_activated) return _relatedConstraints;
				Activate();
				return _relatedConstraints;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 5)]
		public IfcLogicalOperatorEnum @LogicalAggregator 
		{ 
			get 
			{
				if(_activated) return _logicalAggregator;
				Activate();
				return _logicalAggregator;
			} 
			set
			{
				SetValue( v =>  _logicalAggregator = v, _logicalAggregator, value,  "LogicalAggregator", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_relatingConstraint = (IfcConstraint)(value.EntityVal);
					return;
				case 3: 
					_relatedConstraints.InternalAdd((IfcConstraint)value.EntityVal);
					return;
				case 4: 
                    _logicalAggregator = (IfcLogicalOperatorEnum) System.Enum.Parse(typeof (IfcLogicalOperatorEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstraintAggregationRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RelatingConstraint != null)
					yield return @RelatingConstraint;
				foreach(var entity in @RelatedConstraints)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingConstraint != null)
					yield return @RelatingConstraint;
				foreach(var entity in @RelatedConstraints)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}