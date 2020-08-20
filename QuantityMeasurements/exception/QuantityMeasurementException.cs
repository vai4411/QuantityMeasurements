// <copyright file="QuantityMeasurementException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurements
{
    using System;

    /// <summary>
    /// This class used for custom exception creation.
    /// </summary>
    public class QuantityMeasurementException : Exception
    {
        /// <summary>
        /// This variable used for enum type.
        /// </summary>
        public ExceptionType exceptionType;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityMeasurementException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public QuantityMeasurementException(string message, ExceptionType exceptionType)
            : base(message)
        {
            this.exceptionType = exceptionType;
        }

        /// <summary>
        /// This exception type enum.
        /// </summary>
        public enum ExceptionType
        {
            VALUE_MUST_BE_POSITIVE,
        }
    }
}
