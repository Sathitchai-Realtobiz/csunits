// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

namespace Cureos.Measures
{
        /// <summary>
        /// Representation of the unit dimension in terms of SI base units
        /// </summary>
        public sealed class QuantityDimensions
        {
            #region CONSTRUCTORS

            /// <summary>
            /// Initializes an instance of a unit dimension
            /// </summary>
            /// <param name="iLengthExponent">Length exponent</param>
            /// <param name="iMassExponent">Mass exponent</param>
            /// <param name="iTimeExponent">Time exponent</param>
            /// <param name="iElectricCurrentExponent">Electric current exponent</param>
            /// <param name="iTemperatureExponent">Temperature exponent</param>
            /// <param name="iLuminousIntensityExponent">Luminous intensity exponent</param>
            /// <param name="iSubstanceAmountExponent">Substance amount exponent</param>
            internal QuantityDimensions(int iLengthExponent, int iMassExponent, int iTimeExponent, int iElectricCurrentExponent, int iTemperatureExponent,
                int iLuminousIntensityExponent, int iSubstanceAmountExponent)
            {
                LengthExponent = iLengthExponent;
                MassExponent = iMassExponent;
                TimeExponent = iTimeExponent;
                ElectricCurrentExponent = iElectricCurrentExponent;
                TemperatureExponent = iTemperatureExponent;
                LuminousIntensityExponent = iLuminousIntensityExponent;
                SubstanceAmountExponent = iSubstanceAmountExponent;
            }

            #endregion

            #region AUTO-IMPLEMENTED PROPERTIES

            /// <summary>
            /// Gets the length (m) exponent
            /// </summary>
            internal int LengthExponent { get; set; }

            /// <summary>
            /// Gets the mass (kg) exponent
            /// </summary>
            internal int MassExponent { get; set; }

            /// <summary>
            /// Gets the time (s) exponent
            /// </summary>
            internal int TimeExponent { get; set; }

            /// <summary>
            /// Gets the electric current (A) exponent
            /// </summary>
            internal int ElectricCurrentExponent { get; set; }

            /// <summary>
            /// Gets the temperature (K) exponent
            /// </summary>
            internal int TemperatureExponent { get; set; }

            /// <summary>
            /// Gets the luminous intensity (Cd) exponent
            /// </summary>
            internal int LuminousIntensityExponent { get; set; }

            /// <summary>
            /// Gets the substance amount (mol) exponent
            /// </summary>
            internal int SubstanceAmountExponent { get; set; }

            #endregion

            #region METHODS

            internal bool Equals(QuantityDimensions other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return other.LengthExponent == LengthExponent && other.MassExponent == MassExponent &&
                       other.TimeExponent == TimeExponent && other.ElectricCurrentExponent == ElectricCurrentExponent &&
                       other.TemperatureExponent == TemperatureExponent &&
                       other.LuminousIntensityExponent == LuminousIntensityExponent &&
                       other.SubstanceAmountExponent == SubstanceAmountExponent;
            }

            public override bool Equals(object obj)
            {
                return Equals(obj as QuantityDimensions);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int result = LengthExponent;
                    result = (result * 397) ^ MassExponent;
                    result = (result * 397) ^ TimeExponent;
                    result = (result * 397) ^ ElectricCurrentExponent;
                    result = (result * 397) ^ TemperatureExponent;
                    result = (result * 397) ^ LuminousIntensityExponent;
                    result = (result * 397) ^ SubstanceAmountExponent;
                    return result;
                }
            }

            #endregion

            #region OPERATORS

            /// <summary>
            /// Add two unit dimension objects (used in unit multiplication)
            /// </summary>
            /// <param name="iLhs">First unit dimension object</param>
            /// <param name="iRhs">Second unit dimension object</param>
            /// <returns>New unit dimension object, with each exponent being the sum of the two input object exponents</returns>
            public static QuantityDimensions operator +(QuantityDimensions iLhs, QuantityDimensions iRhs)
            {
                return new QuantityDimensions(iLhs.LengthExponent + iRhs.LengthExponent, iLhs.MassExponent + iRhs.MassExponent,
                    iLhs.TimeExponent + iRhs.TimeExponent, iLhs.ElectricCurrentExponent + iRhs.ElectricCurrentExponent,
                    iLhs.TemperatureExponent + iRhs.TemperatureExponent, iLhs.LuminousIntensityExponent + iRhs.LuminousIntensityExponent,
                    iLhs.SubstanceAmountExponent + iRhs.SubstanceAmountExponent);
            }

            /// <summary>
            /// Subtract two unit dimension objects (used in unit division)
            /// </summary>
            /// <param name="iLhs">First unit dimension object</param>
            /// <param name="iRhs">Second unit dimension object</param>
            /// <returns>New unit dimension object, with each exponent being the difference of the two input object exponents</returns>
            public static QuantityDimensions operator -(QuantityDimensions iLhs, QuantityDimensions iRhs)
            {
                return new QuantityDimensions(iLhs.LengthExponent - iRhs.LengthExponent, iLhs.MassExponent - iRhs.MassExponent, 
                    iLhs.TimeExponent - iRhs.TimeExponent, iLhs.ElectricCurrentExponent - iRhs.ElectricCurrentExponent, 
                    iLhs.TemperatureExponent - iRhs.TemperatureExponent, iLhs.LuminousIntensityExponent - iRhs.LuminousIntensityExponent,
                    iLhs.SubstanceAmountExponent - iRhs.SubstanceAmountExponent);
            }

            /// <summary>
            /// Multiply a scalar factor to the quantity dimension object
            /// </summary>
            /// <param name="iExponent">Scalar exponent to multiply</param>
            /// <param name="iRhs">Quantity dimension to be multiplied</param>
            /// <returns>New quantity dimension with all exponents multiplied by <paramref name="iExponent">the specified factor</paramref></returns>
            public static QuantityDimensions operator*(int iExponent, QuantityDimensions iRhs)
            {
                return new QuantityDimensions(iExponent * iRhs.LengthExponent, iExponent * iRhs.MassExponent,
                    iExponent * iRhs.TimeExponent, iExponent * iRhs.ElectricCurrentExponent,
                    iExponent * iRhs.TemperatureExponent, iExponent * iRhs.LuminousIntensityExponent,
                    iExponent * iRhs.SubstanceAmountExponent);
            }

            #endregion
         }
}

