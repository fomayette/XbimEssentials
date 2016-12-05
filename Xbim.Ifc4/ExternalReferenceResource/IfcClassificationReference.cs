// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ExternalReferenceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcClassificationReference
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcClassificationReference : IIfcExternalReference, IfcClassificationReferenceSelect, IfcClassificationSelect
	{
		IIfcClassificationReferenceSelect @ReferencedSource { get;  set; }
		IfcText? @Description { get;  set; }
		IfcIdentifier? @Sort { get;  set; }
		IEnumerable<IIfcRelAssociatesClassification> @ClassificationRefForObjects {  get; }
		IEnumerable<IIfcClassificationReference> @HasReferences {  get; }
	
	}
}

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[ExpressType("IfcClassificationReference", 209)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationReference : IfcExternalReference, IInstantiableEntity, IIfcClassificationReference, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcClassificationReference>
	{
		#region IIfcClassificationReference explicit implementation
		IIfcClassificationReferenceSelect IIfcClassificationReference.ReferencedSource { 
 
 
			get { return @ReferencedSource; } 
			set { ReferencedSource = value as IfcClassificationReferenceSelect;}
		}	
		IfcText? IIfcClassificationReference.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcIdentifier? IIfcClassificationReference.Sort { 
 
			get { return @Sort; } 
			set { Sort = value;}
		}	
		 
		IEnumerable<IIfcRelAssociatesClassification> IIfcClassificationReference.ClassificationRefForObjects {  get { return @ClassificationRefForObjects; } }
		IEnumerable<IIfcClassificationReference> IIfcClassificationReference.HasReferences {  get { return @HasReferences; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassificationReference(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcClassificationReferenceSelect _referencedSource;
		private IfcText? _description;
		private IfcIdentifier? _sort;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcClassificationReferenceSelect @ReferencedSource 
		{ 
			get 
			{
				if(_activated) return _referencedSource;
				Activate();
				return _referencedSource;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _referencedSource = v, _referencedSource, value,  "ReferencedSource", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
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
				SetValue( v =>  _description = v, _description, value,  "Description", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcIdentifier? @Sort 
		{ 
			get 
			{
				if(_activated) return _sort;
				Activate();
				return _sort;
			} 
			set
			{
				SetValue( v =>  _sort = v, _sort, value,  "Sort", 6);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingClassification")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 8)]
		public IEnumerable<IfcRelAssociatesClassification> @ClassificationRefForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesClassification>(e => Equals(e.RelatingClassification), "RelatingClassification", this);
			} 
		}
		[InverseProperty("ReferencedSource")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 9)]
		public IEnumerable<IfcClassificationReference> @HasReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationReference>(e => Equals(e.ReferencedSource), "ReferencedSource", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_referencedSource = (IfcClassificationReferenceSelect)(value.EntityVal);
					return;
				case 4: 
					_description = value.StringVal;
					return;
				case 5: 
					_sort = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcClassificationReference other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ReferencedSource != null)
					yield return @ReferencedSource;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ReferencedSource != null)
					yield return @ReferencedSource;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}