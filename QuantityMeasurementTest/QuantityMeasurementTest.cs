// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurements;

    /// <summary>
    /// This is test class.
    /// </summary>
    public class QuantityMeasurementTest
    {
        /// <summary>
        /// This is setup method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// TC 1.1- zero feet and zero feet return equal.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenZeroFeetCompareWithZeroFeet_ThenReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.FEET, 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.FEET, 0);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.2- null check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenNullCompareWithZeroFeet_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.FEET, 0);
            QuantityUnits unit2 = null;
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.3- ref check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenFeetRefCompareWithSameFeetRef_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit = new QuantityUnits((double)UnitConversion.FEET, 0);
            bool result = quantityMeasurement.EqualtyCheck(unit, unit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.4- type check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenFeetTypeCompareWithFeetType_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.FEET, 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.FEET, 0);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.5- value check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTenFeetValueCompareWithTenFeetValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.FEET, 10);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.FEET, 10);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.6- value check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTenFeetValueCompareWithZeroFeetValue_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.FEET, 10);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.FEET, 0);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.7- zero Inch and zero Inch return equal.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenZeroInchCompareWithZeroInch_ThenReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.INCH, 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.INCH, 0);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.8- null check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenNullCompareWithZeroInch_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.INCH, 0);
            QuantityUnits unit2 = null;
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.9- ref check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenInchRefCompareWithSameInchRef_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit = new QuantityUnits((double)UnitConversion.INCH, 0);
            bool result = quantityMeasurement.EqualtyCheck(unit, unit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.10- type check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenInchTypeCompareWithInchType_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.INCH, 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.INCH, 0);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.11- value check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTenInchValueCompareWithTenInchValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.INCH, 10);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.INCH, 10);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.12- value check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTenInchValueCompareWithZeroInchValue_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.INCH, 10);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.INCH, 0);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }
    }
}