// <copyright file="QuantityUnits.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurements
{
    /// <summary>
    /// This is parent class which consist the equals method.
    /// </summary>
    public class QuantityUnits
    {
        private double quantity;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityUnits"/> class.
        /// </summary>
        /// <param name="conversionType">Conversion type value.</param>
        /// <param name="quantity">Quantity value.</param>
        public QuantityUnits(double conversionType, double quantity)
        {
            this.quantity = quantity * conversionType;
        }

        /// <summary>
        /// This method add the quantity value.
        /// </summary>
        /// <param name="quantityUnits">Quantity object.</param>
        /// <returns>Addition of quantity.</returns>
        public double AddQuantity(QuantityUnits quantityUnits)
        {
            return quantityUnits.quantity + this.quantity;
        }

        /// <summary>
        /// This is equals method for compare objects.
        /// </summary>
        /// <param name="obj">Units object.</param>
        /// <returns>Boolean result.</returns>
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            QuantityUnits units = (QuantityUnits)obj;
            return this.quantity == units.quantity;
        }

        /// <summary>
        /// This is hash code method which return hash code.
        /// </summary>
        /// <returns>Integer hash code.</returns>
        public override int GetHashCode()
        {
            return -1136221603 + this.quantity.GetHashCode();
        }
    }
}