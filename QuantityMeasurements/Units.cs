using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurements
{
    public class Units
    {
        private int quantity;

        public Units(int quantity)
        {
            this.quantity = quantity;
        }

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

            if (this.GetType() == obj.GetType())
            {
                return this.GetType() == obj.GetType();
            }

            Units units = (Units)obj;
            return this.quantity == units.quantity;
        }

        public override int GetHashCode()
        {
            return -1136221603 + quantity.GetHashCode();
        }
    }
}