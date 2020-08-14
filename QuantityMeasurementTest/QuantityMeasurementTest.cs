using NUnit.Framework;
using QuantityMeasurements;

namespace QuantityMeasurementTest
{
    public class QuantityMeasurementTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void givenFeetAndFeet_WhenZero_ShouldReturnTrue()
        {
            Assert.Pass();
            QuantityMeasurement quantity = new QuantityMeasurement();
            Assert.AreEqual(true, quantity.EqualtyCheck(new Feet(0), new Feet(0)));
        }

        [Test]
        public void GivenQuantity_WhenNullCompareWithZeroFeet_ShouldReturnFalse()
        {
            QuantityMeasurement quantity = new QuantityMeasurement();
            Assert.IsFalse(quantity.EqualtyCheck(new Feet(0), null));
        }

        [Test]
        public void GivenQuantity_WhenFeetRefCompareWithFeetRef_ShouldReturnFalse()
        {
            QuantityMeasurement quantity = new QuantityMeasurement();
            Assert.IsFalse(quantity.EqualtyCheck(new Feet(0), new Feet(0)));
        }
    }
}