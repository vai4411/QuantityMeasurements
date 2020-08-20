// <copyright file="UnitConversion.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurements
{
    /// <summary>
    /// This class used to get quantity unit value.
    /// </summary>
    public class UnitConversion
    {
        /// <summary>
        /// This enum manage units.
        /// </summary>
        public enum Units
        {
            FEET,
            INCH,
            YARD,
            CM,
            GALLON,
            LITRE,
            ML,
            KG,
            GM,
            TONNE,
            CELSIUS,
            FAHRENHEIT,
        }

        /// <summary>
        /// This method use for get base unit value.
        /// </summary>
        /// <param name="unit">Unit enum.</param>
        /// <returns>Base value.</returns>
        public static double GetQuantityValue(Units unit)
        {
            switch (unit)
            {
                case Units.FEET:
                    return 12;
                case Units.INCH:
                    return 1;
                case Units.YARD:
                    return 36;
                case Units.CM:
                    return 0.4;
                case Units.GALLON:
                    return 3.78;
                case Units.LITRE:
                    return 1;
                case Units.ML:
                    return 0.001;
                case Units.KG:
                    return 1;
                case Units.GM:
                    return 0.001;
                case Units.TONNE:
                    return 1000;
                case Units.CELSIUS:
                    return 1;
                case Units.FAHRENHEIT:
                    return 1;
            }

            return 0.0;
        }
    }
}