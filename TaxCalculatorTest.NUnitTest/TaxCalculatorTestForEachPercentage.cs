using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator;

namespace TaxCalculatorTest.NUnitTest
{
    public class TaxCalculatorTestForEachPercentage
    {
        [Test]
        public void CalCulateFirst300ThousandFor7Percent()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalCulateFirst300Thousand(300000);

            //assert
            Assert.That(result, Is.EqualTo(21000.00m));
        }
        [Test]
        public void CalCulateFirst300ThousandFor7Percent_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalCulateFirst300Thousand(300000);

            //assert
            Assert.That(result, Is.Not.EqualTo(22000.00m));
        }
        [Test]
        public void CalCulateSecond300ThousandFor11Percent()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateSecond300Thousand(600000);

            //assert
            Assert.That(result, Is.EqualTo(66000.00m));
        }
        [Test]
        public void CalCulateSecond300ThousandFor7Percent_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateSecond300Thousand(600000);

            //assert
            Assert.That(result, Is.Not.EqualTo(2000.00m));
        }
        [Test]
        public void CalCulateFirst500ThousandFor15Percent()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateThird500Thousand(1100000);

            //assert
            Assert.That(result, Is.EqualTo(165000.00m));
        }
        [Test]
        public void CalCulateFirst500ThousandFor15Percent_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateThird500Thousand(1100000);

            //assert
            Assert.That(result, Is.Not.EqualTo(22000.00m));
        }
        [Test]
        public void CalCulateSecond500ThousandFor19Percent()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateFourth500Thousand(1600000);

            //assert
            Assert.That(result, Is.EqualTo(304000.00m));
        }
        [Test]
        public void CalCulateSecond500ThousandFor19Percent_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateFourth500Thousand(1600000);

            //assert
            Assert.That(result, Is.Not.EqualTo(223000.00m));
        }
        [Test]
        public void CalCulateNextOnePointSixMillionThousandFor21Percent()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateOnePointSixMillion(2100000);

            //assert
            Assert.That(result, Is.EqualTo(441000.00m));
        }
        [Test]
        public void CalCulateNextOnePointSixMillionThousandFor21Percent_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateFourth500Thousand(2100000);

            //assert
            Assert.That(result, Is.Not.EqualTo(223000.00m));
        }
        [Test]
        public void CalCulateNextThreePointTwoMillionThousandFor24Percent()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateThreePointTwoMillion(3200000);

            //assert
            Assert.That(result, Is.EqualTo(672000.00m));
        }
        [Test]
        public void CalCulateNextThreePointTwoMillionThousandFor24Percent_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateThreePointTwoMillion(3200000);

            //assert
            Assert.That(result, Is.Not.EqualTo(223000.00m));
        }
    }
}
