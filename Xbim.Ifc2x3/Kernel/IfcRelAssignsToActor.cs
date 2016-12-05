// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssignsToActor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssignsToActor : IIfcRelAssigns
	{
		IIfcActor @RelatingActor { get;  set; }
		IIfcActorRole @ActingRole { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcRelAssignsToActor", 323)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsToActor : IfcRelAssigns, IInstantiableEntity, IIfcRelAssignsToActor, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelAssignsToActor>
	{
		#region IIfcRelAssignsToActor explicit implementation
		IIfcActor IIfcRelAssignsToActor.RelatingActor { 
 
 
			get { return @RelatingActor; } 
			set { RelatingActor = value as IfcActor;}
		}	
		IIfcActorRole IIfcRelAssignsToActor.ActingRole { 
 
 
			get { return @ActingRole; } 
			set { ActingRole = value as IfcActorRole;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToActor(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcActor _relatingActor;
		private IfcActorRole _actingRole;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcActor @RelatingActor 
		{ 
			get 
			{
				if(_activated) return _relatingActor;
				Activate();
				return _relatingActor;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingActor = v, _relatingActor, value,  "RelatingActor", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public IfcActorRole @ActingRole 
		{ 
			get 
			{
				if(_activated) return _actingRole;
				Activate();
				return _actingRole;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _actingRole = v, _actingRole, value,  "ActingRole", 8);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_relatingActor = (IfcActor)(value.EntityVal);
					return;
				case 7: 
					_actingRole = (IfcActorRole)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssignsToActor other)
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
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingActor != null)
					yield return @RelatingActor;
				if (@ActingRole != null)
					yield return @ActingRole;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingActor != null)
					yield return @RelatingActor;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}