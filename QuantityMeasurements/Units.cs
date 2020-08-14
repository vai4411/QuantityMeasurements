using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurements
{
    public class Units
    {
        private int length;

        public Units(int length)
        {
            this.length = length;
        }

        public override bool Equals(object obj)
        {
            return obj is Units units &&
                   length == units.length;
        }

        public override int GetHashCode()
        {
            return -1136221603 + length.GetHashCode();
        }
    }
}