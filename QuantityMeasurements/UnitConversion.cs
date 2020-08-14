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
        }

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
            }
            return 0.0;
        }
    }
}