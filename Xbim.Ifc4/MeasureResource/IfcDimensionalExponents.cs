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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDimensionalExponents
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDimensionalExponents : IPersistEntity
	{
		long @LengthExponent { get;  set; }
		long @MassExponent { get;  set; }
		long @TimeExponent { get;  set; }
		long @ElectricCurrentExponent { get;  set; }
		long @ThermodynamicTemperatureExponent { get;  set; }
		long @AmountOfSubstanceExponent { get;  set; }
		long @LuminousIntensityExponent { get;  set; }
	
	}
}

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IfcDimensionalExponents", 303)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDimensionalExponents : PersistEntity, IInstantiableEntity, IIfcDimensionalExponents, IEquatable<@IfcDimensionalExponents>
	{
		#region IIfcDimensionalExponents explicit implementation
		long IIfcDimensionalExponents.LengthExponent { 
 
			get { return @LengthExponent; } 
			set { LengthExponent = value;}
		}	
		long IIfcDimensionalExponents.MassExponent { 
 
			get { return @MassExponent; } 
			set { MassExponent = value;}
		}	
		long IIfcDimensionalExponents.TimeExponent { 
 
			get { return @TimeExponent; } 
			set { TimeExponent = value;}
		}	
		long IIfcDimensionalExponents.ElectricCurrentExponent { 
 
			get { return @ElectricCurrentExponent; } 
			set { ElectricCurrentExponent = value;}
		}	
		long IIfcDimensionalExponents.ThermodynamicTemperatureExponent { 
 
			get { return @ThermodynamicTemperatureExponent; } 
			set { ThermodynamicTemperatureExponent = value;}
		}	
		long IIfcDimensionalExponents.AmountOfSubstanceExponent { 
 
			get { return @AmountOfSubstanceExponent; } 
			set { AmountOfSubstanceExponent = value;}
		}	
		long IIfcDimensionalExponents.LuminousIntensityExponent { 
 
			get { return @LuminousIntensityExponent; } 
			set { LuminousIntensityExponent = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDimensionalExponents(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private long _lengthExponent;
		private long _massExponent;
		private long _timeExponent;
		private long _electricCurrentExponent;
		private long _thermodynamicTemperatureExponent;
		private long _amountOfSubstanceExponent;
		private long _luminousIntensityExponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public long @LengthExponent 
		{ 
			get 
			{
				if(_activated) return _lengthExponent;
				Activate();
				return _lengthExponent;
			} 
			set
			{
				SetValue( v =>  _lengthExponent = v, _lengthExponent, value,  "LengthExponent", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public long @MassExponent 
		{ 
			get 
			{
				if(_activated) return _massExponent;
				Activate();
				return _massExponent;
			} 
			set
			{
				SetValue( v =>  _massExponent = v, _massExponent, value,  "MassExponent", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public long @TimeExponent 
		{ 
			get 
			{
				if(_activated) return _timeExponent;
				Activate();
				return _timeExponent;
			} 
			set
			{
				SetValue( v =>  _timeExponent = v, _timeExponent, value,  "TimeExponent", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public long @ElectricCurrentExponent 
		{ 
			get 
			{
				if(_activated) return _electricCurrentExponent;
				Activate();
				return _electricCurrentExponent;
			} 
			set
			{
				SetValue( v =>  _electricCurrentExponent = v, _electricCurrentExponent, value,  "ElectricCurrentExponent", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public long @ThermodynamicTemperatureExponent 
		{ 
			get 
			{
				if(_activated) return _thermodynamicTemperatureExponent;
				Activate();
				return _thermodynamicTemperatureExponent;
			} 
			set
			{
				SetValue( v =>  _thermodynamicTemperatureExponent = v, _thermodynamicTemperatureExponent, value,  "ThermodynamicTemperatureExponent", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public long @AmountOfSubstanceExponent 
		{ 
			get 
			{
				if(_activated) return _amountOfSubstanceExponent;
				Activate();
				return _amountOfSubstanceExponent;
			} 
			set
			{
				SetValue( v =>  _amountOfSubstanceExponent = v, _amountOfSubstanceExponent, value,  "AmountOfSubstanceExponent", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public long @LuminousIntensityExponent 
		{ 
			get 
			{
				if(_activated) return _luminousIntensityExponent;
				Activate();
				return _luminousIntensityExponent;
			} 
			set
			{
				SetValue( v =>  _luminousIntensityExponent = v, _luminousIntensityExponent, value,  "LuminousIntensityExponent", 7);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_lengthExponent = value.IntegerVal;
					return;
				case 1: 
					_massExponent = value.IntegerVal;
					return;
				case 2: 
					_timeExponent = value.IntegerVal;
					return;
				case 3: 
					_electricCurrentExponent = value.IntegerVal;
					return;
				case 4: 
					_thermodynamicTemperatureExponent = value.IntegerVal;
					return;
				case 5: 
					_amountOfSubstanceExponent = value.IntegerVal;
					return;
				case 6: 
					_luminousIntensityExponent = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDimensionalExponents other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
        public void Initialise(XbimDimensionalExponents exponent)
        {
            AmountOfSubstanceExponent = exponent.AmountOfSubstanceExponent;
            ElectricCurrentExponent = exponent.ElectricCurrentExponent;
            LengthExponent = exponent.LengthExponent;
            LuminousIntensityExponent = exponent.LuminousIntensityExponent;
            MassExponent = exponent.MassExponent;
            ThermodynamicTemperatureExponent = exponent.ThermodynamicTemperatureExponent;
            TimeExponent = exponent.TimeExponent;

        }
		//##
		#endregion
	}
}