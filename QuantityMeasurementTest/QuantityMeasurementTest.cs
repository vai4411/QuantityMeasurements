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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
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
            QuantityUnits unit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 10);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 10);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 10);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
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
            QuantityUnits unit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 10);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 10);
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
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 10);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.13- comparison check for zero feet and zero inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenZeroFeetValueCompareWithZeroFeetValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.14- comparison check for one feet and one inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneFeetValueCompareWithOneInchValue_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 1);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.15- comparison check for one feet and one inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneInchValueCompareWithOneFeetValue_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.16- comparison check for one feet and twelve inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneFeetValueCompareWithTwelveInchValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 12);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.17- comparison check for twelve inch and one feet.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTwelveInchValueCompareWithOneFeetValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 12);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.18- comparison check for three feet and one yard.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenThreeFeetValueCompareWithOneYardValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 3);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.19- comparison check for one feet and one yard.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneFeetValueCompareWithOneYardValue_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.20- comparison check for one inch and one yard.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneInchValueCompareWithOneYardValue_ShouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.21- comparison check for one yard and thirtysix inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneyardValueCompareWithThirtySixInchValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 36);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.22- comparison check for thirtysix inch and one yard.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenThirtySixInchValueCompareWithOneYardValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 36);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.23- comparison check for one yard and three feet.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneYardValueCompareWithThreeFeetValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 3);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.24- comparison check for two inch and five cm.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTwoInchValueCompareWithFiveCMValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.CM), 5);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.25- comparison check for four inch with addition of two inch and two inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenFourInchValueCompareWithAdditionOfTwoInchAndTwoInchValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits unit3 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 4);
            double unit4 = quantityMeasurement.AddQuantityUnits(unit1, unit2);
            QuantityUnits unit5 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), unit4);
            bool result = quantityMeasurement.EqualtyCheck(unit3, unit5);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.26- comparison check for fourteen inch with addition of one feet and two inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenFourteenInchValueCompareWithAdditionOfOneFeetAndTwoInchValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits unit3 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 14);
            double unit4 = quantityMeasurement.AddQuantityUnits(unit1, unit2);
            QuantityUnits unit5 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), unit4);
            bool result = quantityMeasurement.EqualtyCheck(unit3, unit5);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.27- comparison check for twenty four inch with addition of one feet and one feet.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTwentyFourInchValueCompareWithAdditionOfOneFeetAndOneFeetValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits unit3 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 24);
            double unit4 = quantityMeasurement.AddQuantityUnits(unit1, unit2);
            QuantityUnits unit5 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), unit4);
            bool result = quantityMeasurement.EqualtyCheck(unit3, unit5);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.28- comparison check for three inch with addition of two inch and two point five cm.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenThreeInchValueCompareWithAdditionOfTwoInchAndTwoPointFiveValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.CM), 2.5);
            QuantityUnits unit3 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 3);
            double unit4 = quantityMeasurement.AddQuantityUnits(unit1, unit2);
            QuantityUnits unit5 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), unit4);
            bool result = quantityMeasurement.EqualtyCheck(unit3, unit5);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.29- comparison check for one gallon and three point seventy eight litre.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneGallonValueCompareWithThreePointSeventyEightLitreValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.GALLON), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), 3.78);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.30- comparison check for one litre and thousand ml.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneLitreValueCompareWithThousandMLValue_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            QuantityUnits unit1 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), 1);
            QuantityUnits unit2 = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.ML), 1000);
            bool result = quantityMeasurement.EqualtyCheck(unit1, unit2);
            Assert.IsTrue(result);
        }
    }
}