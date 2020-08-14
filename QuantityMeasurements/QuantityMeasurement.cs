// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

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
        /// <param name="firstQuantity">Units of length.</param>
        /// <param name="lastQuantity"><see cref="QuantityUnits"/> of length.</param>
        /// <returns>Boolean result.</returns>
        public bool EqualtyCheck(QuantityUnits firstQuantity, QuantityUnits lastQuantity)
        {
            return firstQuantity.Equals(lastQuantity);
        }
    }
}