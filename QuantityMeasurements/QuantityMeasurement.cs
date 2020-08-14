// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using static QuantityMeasurements.UnitConversion;

namespace QuantityMeasurements
{
    /// <summary>
    /// This is main class of quantity measurement.
    /// </summary>
    public class QuantityMeasurement
    {
        /// <summary>
        /// This method used for check Units objects same or not.
        /// </summary>
        /// <param name="firstQuantity">Unit of quantity.</param>
        /// <param name="secondQuantity"><see cref="QuantityUnits"/>Unit of quantity.</param>
        /// <returns>Boolean result.</returns>
        public bool EqualtyCheck(QuantityUnits firstQuantity, QuantityUnits secondQuantity)
        {
            return firstQuantity.Equals(secondQuantity);
        }

        /// <summary>
        /// This method add the quantity value.
        /// </summary>
        /// <param name="firstQuantity">Unit of quantity.</param>
        /// <param name="secondQuantity">Unit of quantity.</param>
        /// <returns>Addition of quantity.</returns>
        public double AddQuantityUnits(QuantityUnits firstQuantity, QuantityUnits secondQuantity)
        {
            return firstQuantity.AddQuantity(secondQuantity);
        }

        /// <summary>
        /// This method use for tempreture conversion.
        /// </summary>
        /// <param name="unit">Unit type.</param>
        /// <param name="temperature">Temperature quantity.</param>
        /// <returns>Temperature value.</returns>
        public double TemperatureConversion(Units unit, double temperature)
        {
            if (unit == Units.FAHRENHEIT)
                return (temperature * 9 / 5) + 32;
            return temperature;
        }
    }
}