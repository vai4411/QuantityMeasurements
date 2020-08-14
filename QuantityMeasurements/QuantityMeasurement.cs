using QuantityMeasurement;
using System;

namespace QuantityMeasurements
{
    public class QuantityMeasurement
    {
        public bool EqualtyCheck(Units lengthOne, Units lengthTwo)
        {
            if (lengthOne == null || lengthTwo == null)
                return false;
            return lengthOne.Equals(lengthTwo);
        }
    }
}