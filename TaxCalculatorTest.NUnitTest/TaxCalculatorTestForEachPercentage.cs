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
        private ITaxCalculator _taxCalculator;
        [SetUp]
        public void Setup()
        {
            _taxCalculator = new TaxCalculatorService();
        }

        [Test]
        public void CalCulateFirst300ThousandFor7Percent_IncomeIs300000_Return7PercentOfIncome()
        {

            //act
            var result = _taxCalculator.CalCulateFirst300Thousand(300000);

            //assert
            Assert.That(result, Is.EqualTo(21000.00m));
        }
 
        [Test]
        public void CalCulateSecond300ThousandFor11Percent_IncomeIs600000_Return11PercentOfIncome()
        {
            //act
            var result = _taxCalculator.CalculateSecond300Thousand(600000);

            //assert
            Assert.That(result, Is.EqualTo(66000.00m));
        }
       
        [Test]
        public void CalCulateFirst500ThousandFor15Percent_IncomeIs1100000_Return15PercentOfIncome()
        {
            //act
            var result = _taxCalculator.CalculateThird500Thousand(1100000);

            //assert
            Assert.That(result, Is.EqualTo(165000.00m));
        }
        [Test]
        public void CalCulateSecond500ThousandFor19Percent_IncomeIs1600000_Return19PercentOfIncome()
        {
            //act
            var result = _taxCalculator.CalculateFourth500Thousand(1600000);

            //assert
            Assert.That(result, Is.EqualTo(304000.00m));
        }
        [Test]
        public void CalCulateNextOnePointSixMillionThousandFor21Percent_IncomeIs2100000_Return21PercentOfIncome()
        {
            //act
            var result = _taxCalculator.CalculateOnePointSixMillion(2100000);

            //assert
            Assert.That(result, Is.EqualTo(441000.00m));
        }
        [Test]
        public void CalCulateNextThreePointTwoMillionThousandFor24Percent_IncomeIs3200000_Return24PercentOfIncome()
        {
            //act
            var result = _taxCalculator.CalculateThreePointTwoMillion(3200000);

            //assert
            Assert.That(result, Is.EqualTo(672000.00m));
        }
        
    }
}
