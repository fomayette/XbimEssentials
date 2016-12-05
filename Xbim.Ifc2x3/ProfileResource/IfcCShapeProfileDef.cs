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
using Xbim.Ifc2x3.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCShapeProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @Depth { get;  set; }
		IfcPositiveLengthMeasure @Width { get;  set; }
		IfcPositiveLengthMeasure @WallThickness { get;  set; }
		IfcPositiveLengthMeasure @Girth { get;  set; }
		IfcPositiveLengthMeasure? @InternalFilletRadius { get;  set; }
		IfcPositiveLengthMeasure? @CentreOfGravityInX { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IfcCShapeProfileDef", 501)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcCShapeProfileDef, IContainsEntityReferences, IEquatable<@IfcCShapeProfileDef>
	{
		#region IIfcCShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcCShapeProfileDef.Depth { 
 
			get { return @Depth; } 
			set { Depth = value;}
		}	
		IfcPositiveLengthMeasure IIfcCShapeProfileDef.Width { 
 
			get { return @Width; } 
			set { Width = value;}
		}	
		IfcPositiveLengthMeasure IIfcCShapeProfileDef.WallThickness { 
 
			get { return @WallThickness; } 
			set { WallThickness = value;}
		}	
		IfcPositiveLengthMeasure IIfcCShapeProfileDef.Girth { 
 
			get { return @Girth; } 
			set { Girth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcCShapeProfileDef.InternalFilletRadius { 
 
			get { return @InternalFilletRadius; } 
			set { InternalFilletRadius = value;}
		}	
		IfcPositiveLengthMeasure? IIfcCShapeProfileDef.CentreOfGravityInX { 
 
			get { return @CentreOfGravityInX; } 
			set { CentreOfGravityInX = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCShapeProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure _width;
		private IfcPositiveLengthMeasure _wallThickness;
		private IfcPositiveLengthMeasure _girth;
		private IfcPositiveLengthMeasure? _internalFilletRadius;
		private IfcPositiveLengthMeasure? _centreOfGravityInX;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(_activated) return _depth;
				Activate();
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure @Width 
		{ 
			get 
			{
				if(_activated) return _width;
				Activate();
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure @WallThickness 
		{ 
			get 
			{
				if(_activated) return _wallThickness;
				Activate();
				return _wallThickness;
			} 
			set
			{
				SetValue( v =>  _wallThickness = v, _wallThickness, value,  "WallThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcPositiveLengthMeasure @Girth 
		{ 
			get 
			{
				if(_activated) return _girth;
				Activate();
				return _girth;
			} 
			set
			{
				SetValue( v =>  _girth = v, _girth, value,  "Girth", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcPositiveLengthMeasure? @InternalFilletRadius 
		{ 
			get 
			{
				if(_activated) return _internalFilletRadius;
				Activate();
				return _internalFilletRadius;
			} 
			set
			{
				SetValue( v =>  _internalFilletRadius = v, _internalFilletRadius, value,  "InternalFilletRadius", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInX 
		{ 
			get 
			{
				if(_activated) return _centreOfGravityInX;
				Activate();
				return _centreOfGravityInX;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInX = v, _centreOfGravityInX, value,  "CentreOfGravityInX", 9);
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
					_depth = value.RealVal;
					return;
				case 4: 
					_width = value.RealVal;
					return;
				case 5: 
					_wallThickness = value.RealVal;
					return;
				case 6: 
					_girth = value.RealVal;
					return;
				case 7: 
					_internalFilletRadius = value.RealVal;
					return;
				case 8: 
					_centreOfGravityInX = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCShapeProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}