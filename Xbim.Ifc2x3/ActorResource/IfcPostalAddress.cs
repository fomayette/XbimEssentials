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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPostalAddress
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPostalAddress : IIfcAddress
	{
		IfcLabel? @InternalLocation { get;  set; }
		IItemSet<IfcLabel> @AddressLines { get; }
		IfcLabel? @PostalBox { get;  set; }
		IfcLabel? @Town { get;  set; }
		IfcLabel? @Region { get;  set; }
		IfcLabel? @PostalCode { get;  set; }
		IfcLabel? @Country { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ActorResource
{
	[ExpressType("IfcPostalAddress", 662)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPostalAddress : IfcAddress, IInstantiableEntity, IIfcPostalAddress, IEquatable<@IfcPostalAddress>
	{
		#region IIfcPostalAddress explicit implementation
		IfcLabel? IIfcPostalAddress.InternalLocation { 
 
			get { return @InternalLocation; } 
			set { InternalLocation = value;}
		}	
		IItemSet<IfcLabel> IIfcPostalAddress.AddressLines { 
			get { return @AddressLines; } 
		}	
		IfcLabel? IIfcPostalAddress.PostalBox { 
 
			get { return @PostalBox; } 
			set { PostalBox = value;}
		}	
		IfcLabel? IIfcPostalAddress.Town { 
 
			get { return @Town; } 
			set { Town = value;}
		}	
		IfcLabel? IIfcPostalAddress.Region { 
 
			get { return @Region; } 
			set { Region = value;}
		}	
		IfcLabel? IIfcPostalAddress.PostalCode { 
 
			get { return @PostalCode; } 
			set { PostalCode = value;}
		}	
		IfcLabel? IIfcPostalAddress.Country { 
 
			get { return @Country; } 
			set { Country = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPostalAddress(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_addressLines = new OptionalItemSet<IfcLabel>( this, 0,  5);
		}

		#region Explicit attribute fields
		private IfcLabel? _internalLocation;
		private readonly OptionalItemSet<IfcLabel> _addressLines;
		private IfcLabel? _postalBox;
		private IfcLabel? _town;
		private IfcLabel? _region;
		private IfcLabel? _postalCode;
		private IfcLabel? _country;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcLabel? @InternalLocation 
		{ 
			get 
			{
				if(_activated) return _internalLocation;
				Activate();
				return _internalLocation;
			} 
			set
			{
				SetValue( v =>  _internalLocation = v, _internalLocation, value,  "InternalLocation", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 7)]
		public IOptionalItemSet<IfcLabel> @AddressLines 
		{ 
			get 
			{
				if(_activated) return _addressLines;
				Activate();
				return _addressLines;
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcLabel? @PostalBox 
		{ 
			get 
			{
				if(_activated) return _postalBox;
				Activate();
				return _postalBox;
			} 
			set
			{
				SetValue( v =>  _postalBox = v, _postalBox, value,  "PostalBox", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcLabel? @Town 
		{ 
			get 
			{
				if(_activated) return _town;
				Activate();
				return _town;
			} 
			set
			{
				SetValue( v =>  _town = v, _town, value,  "Town", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcLabel? @Region 
		{ 
			get 
			{
				if(_activated) return _region;
				Activate();
				return _region;
			} 
			set
			{
				SetValue( v =>  _region = v, _region, value,  "Region", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcLabel? @PostalCode 
		{ 
			get 
			{
				if(_activated) return _postalCode;
				Activate();
				return _postalCode;
			} 
			set
			{
				SetValue( v =>  _postalCode = v, _postalCode, value,  "PostalCode", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcLabel? @Country 
		{ 
			get 
			{
				if(_activated) return _country;
				Activate();
				return _country;
			} 
			set
			{
				SetValue( v =>  _country = v, _country, value,  "Country", 10);
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
					_internalLocation = value.StringVal;
					return;
				case 4: 
					_addressLines.InternalAdd(value.StringVal);
					return;
				case 5: 
					_postalBox = value.StringVal;
					return;
				case 6: 
					_town = value.StringVal;
					return;
				case 7: 
					_region = value.StringVal;
					return;
				case 8: 
					_postalCode = value.StringVal;
					return;
				case 9: 
					_country = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPostalAddress other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}