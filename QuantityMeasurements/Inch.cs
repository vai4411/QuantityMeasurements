using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurements
{
    public class Inch : Units
    {
        public Inch(int length) : base(length * 12)
        {
        }
    }
}