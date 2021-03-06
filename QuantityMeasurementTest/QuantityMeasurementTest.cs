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
        private QuantityMeasurement quantityMeasurement;

        /// <summary>
        /// This is setup method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
        }

        /// <summary>
        /// TC 1.1- zero feet and zero feet return equal.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenZeroFeetCompareWithZeroFeet_ThenReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.2- null check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenNullCompareWithZeroFeet_ShouldReturnFalse()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits secondUnit = null;
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.3- ref check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenFeetRefCompareWithSameFeetRef_ShouldReturnTrue()
        {
            QuantityUnits unit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(unit, unit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.4- type check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenFeetTypeCompareWithFeetType_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.5- value check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTenFeetValueCompareWithTenFeetValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 10);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 10);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.6- value check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTenFeetValueCompareWithZeroFeetValue_ShouldReturnFalse()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 10);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.7- zero Inch and zero Inch return equal.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenZeroInchCompareWithZeroInch_ThenReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.8- null check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenNullCompareWithZeroInch_ShouldReturnFalse()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            QuantityUnits secondUnit = null;
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.9- ref check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenInchRefCompareWithSameInchRef_ShouldReturnTrue()
        {
            QuantityUnits unit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(unit, unit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.10- type check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenInchTypeCompareWithInchType_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.11- value check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTenInchValueCompareWithTenInchValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 10);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 10);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.12- value check.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTenInchValueCompareWithZeroInchValue_ShouldReturnFalse()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 10);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.13- comparison check for zero feet and zero inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenZeroFeetValueCompareWithZeroFeetValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 0);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 0);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.14- comparison check for one feet and one inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneFeetValueCompareWithOneInchValue_ShouldReturnFalse()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 1);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.15- comparison check for one feet and one inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneInchValueCompareWithOneFeetValue_ShouldReturnFalse()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.16- comparison check for one feet and twelve inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneFeetValueCompareWithTwelveInchValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 12);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.17- comparison check for twelve inch and one feet.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTwelveInchValueCompareWithOneFeetValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 12);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.18- comparison check for three feet and one yard.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenThreeFeetValueCompareWithOneYardValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 3);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.19- comparison check for one feet and one yard.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneFeetValueCompareWithOneYardValue_ShouldReturnFalse()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.20- comparison check for one inch and one yard.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneInchValueCompareWithOneYardValue_ShouldReturnFalse()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// TC 1.21- comparison check for one yard and thirtysix inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneyardValueCompareWithThirtySixInchValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 36);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.22- comparison check for thirtysix inch and one yard.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenThirtySixInchValueCompareWithOneYardValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 36);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.23- comparison check for one yard and three feet.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneYardValueCompareWithThreeFeetValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.YARD), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 3);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.24- comparison check for two inch and five cm.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTwoInchValueCompareWithFiveCMValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.CM), 5);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.25- comparison check for four inch with addition of two inch and two inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenFourInchValueCompareWithAdditionOfTwoInchAndTwoInchValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 4);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits thirdUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            double additionOfUnits = this.quantityMeasurement.AddQuantityUnits(thirdUnit, secondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), additionOfUnits);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, newAdditionUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.26- comparison check for fourteen inch with addition of one feet and two inch.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenFourteenInchValueCompareWithAdditionOfOneFeetAndTwoInchValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 14);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits thirdUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            double additionOfUnits = this.quantityMeasurement.AddQuantityUnits(thirdUnit, secondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), additionOfUnits);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, newAdditionUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.27- comparison check for twenty four inch with addition of one feet and one feet.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTwentyFourInchValueCompareWithAdditionOfOneFeetAndOneFeetValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 24);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            QuantityUnits thirdUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), 1);
            double additionOfUnits = this.quantityMeasurement.AddQuantityUnits(thirdUnit, secondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), additionOfUnits);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, newAdditionUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.28- comparison check for three inch with addition of two inch and two point five cm.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenThreeInchValueCompareWithAdditionOfTwoInchAndTwoPointFiveValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 3);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), 2);
            QuantityUnits thirdUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.CM), 2.5);
            double additionOfUnits = this.quantityMeasurement.AddQuantityUnits(thirdUnit, secondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.INCH), additionOfUnits);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, newAdditionUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.29- comparison check for one gallon and three point seventy eight litre.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneGallonValueCompareWithThreePointSeventyEightLitreValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.GALLON), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), 3.78);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.30- comparison check for one litre and thousand ml.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneLitreValueCompareWithThousandMLValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.ML), 1000);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.31- comparison check for seven point fifty six litre with addition of one gallon and tree point seventy eight litre.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenSevenPointFiftySixLitreValueCompareWithAdditionOfOneGallonAndThreePointSeventyEightLitreValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), 7.56);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.GALLON), 1);
            QuantityUnits thirdUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), 3.78);
            double additionOfUnits = this.quantityMeasurement.AddQuantityUnits(thirdUnit, secondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), additionOfUnits);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, newAdditionUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.32- comparison check for two litre with addition of one litre and thousand litre.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenSevenPointFiftySixLitreValueCompareWithAdditionOfOneGallonAndThousandLitreValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), 2);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.ML), 1000);
            QuantityUnits thirdUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), 1);
            double additionOfUnits = this.quantityMeasurement.AddQuantityUnits(thirdUnit, secondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), additionOfUnits);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, newAdditionUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.33- comparison check for one kg and thousand gm.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneKGValueCompareWithThousandGMValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.KG), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.GM), 1000);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.34- comparison check for one tonne and thousand kg.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneTonneValueCompareWithThousandKGValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.TONNE), 1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.KG), 1000);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.35- comparison check for one thousand one kg with addition of one tonne and thousand gm.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenOneThousandOneKGValueCompareWithAdditionOfOneTonneAndThousandGMValue_ShouldReturnTrue()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.KG), 1001);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.TONNE), 1);
            QuantityUnits thirdUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.GM), 1000);
            double additionOfUnits = this.quantityMeasurement.AddQuantityUnits(thirdUnit, secondUnit);
            QuantityUnits newAdditionUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.LITRE), additionOfUnits);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, newAdditionUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.36- comparison check for two hundred twelve fahrenheit and hundred celsius.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenTwoHundredTwelveFahrenheitValueCompareWithHundredCelsiusValue_ShouldReturnTrue()
        {
            double firstTemperatureUnit = this.quantityMeasurement.TemperatureConversion(UnitConversion.Units.CELSIUS, 100);
            double secondTemperatureUnit = this.quantityMeasurement.TemperatureConversion(UnitConversion.Units.FAHRENHEIT, 212);
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.CELSIUS), firstTemperatureUnit);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FAHRENHEIT), secondTemperatureUnit);
            bool result = this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TC 1.37- negative unit should throw exception.
        /// </summary>
        [Test]
        public void GivenQuantity_WhenUnitIsNegative_ThenThrowException()
        {
            QuantityUnits firstUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), -1);
            QuantityUnits secondUnit = new QuantityUnits((double)UnitConversion.GetQuantityValue(UnitConversion.Units.FEET), -1);
            var result = Assert.Throws<QuantityMeasurementException>(() => this.quantityMeasurement.EqualtyCheck(firstUnit, secondUnit));
            Assert.AreEqual(QuantityMeasurementException.ExceptionType.VALUE_MUST_BE_POSITIVE, result.exceptionType);
        }
    }
}