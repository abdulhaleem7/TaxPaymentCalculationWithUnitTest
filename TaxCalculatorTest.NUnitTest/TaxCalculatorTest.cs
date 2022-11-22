using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator;

namespace TaxCalculatorTest.NUnitTest
{
    public class TaxCalculatorTest
    {
        private ITaxCalculator _taxCalculator;
        [SetUp]
        public void Setup()
        {
            _taxCalculator = new TaxCalculatorService();
        }
        [Test]
        public void CalculateTaxableIncome_Income543000m_ShouldReturnTaxableIncome()
        {
            //act
            var result = _taxCalculator.CalculateTaxableIncome(543000m);

            //assert
            Assert.That(result, Is.EqualTo(4595776.000m));
        }
        [Test]
        public void CalculateTaxableIncome_Income6890000_ShouldReturnTaxableIncome()
        {

            //act
            var result = _taxCalculator.CalculateTaxableIncome(6890000);

            //assert
            Assert.That(result, Is.EqualTo(60025680.000m));
        }
        [Test]
        public void CalculateTaxableIncome_Income400000_ShouldReturnTaxableIncome()
        {

            //act
            var result = _taxCalculator.CalculateTaxableIncome(400000);

            //assert
            Assert.That(result, Is.EqualTo(3332800.000m));
        }
        [Test]
        public void CalculateTaxableIncome_IncomeLessThanZero_ShouldReturnAnException()
         {

             //assert
             Assert.Throws<ArgumentException>(()=> _taxCalculator.CalculateTaxableIncome(30000));
         }
        [Test]
        public void CalculateMonthlyTaxPayment_Income900000_ShouldReturnMonthlyTaxPayment()
        {
            //act
            var result = _taxCalculator.CalculateTaxPaymentPerMonth(900000);

            //assert
            Assert.That(result, Is.EqualTo(126270.66666666666666666666667m));
        }
        [Test]
        public void CalculateMonthlyTaxPaymen_Income6890000_ShouldReturnMonthlyTaxPayment()
        {
            //act
            var result = _taxCalculator.CalculateTaxPaymentPerMonth(6890000);

            //assert
            Assert.That(result, Is.EqualTo(1041116.0666666666666666666667m));
        }
        [Test]
        public void Calculate_MonthlyTaxPayment_Income400000_ShouldReturnMonthlyTaxPayment()
        {
            //act
            var result = _taxCalculator.CalculateTaxPaymentPerMonth(400000);

            //assert
            Assert.That(result, Is.EqualTo(48990.666666666666666666666667m));
        }
        [Test]
        public void CalculateMonthlyTaxPayment_Income1700000_ShouldReturnMonthlyTaxPayment()
        {
            //act
            var result = _taxCalculator.CalculateTaxPaymentPerMonth(1700000);

            //assert
            Assert.That(result, Is.EqualTo(249848.66666666666666666666667m));
        }
        [Test]
        public void CalculateMonthlyTaxPayment_Income6890000_ShouldReturnNotEqualToMonthlyTaxPayment()
        {
            //act
            var result = _taxCalculator.CalculateTaxPaymentPerMonth(6890000);

            //assert
            Assert.That(result, Is.Not.EqualTo(141116.0666666666666666666667m));
        }
        [Test]
        public void CalculateMonthlyTaxPayment_Income400000_ShouldReturnNotEqualToMonthlyTaxPayment()
        {
            //act
            var result = _taxCalculator.CalculateTaxPaymentPerMonth(400000);

            //assert
            Assert.That(result, Is.Not.EqualTo(4990.666666666666666666666667m));
        }
        [Test]
        public void CalculateMonthlyTaxPayment_Income1700000_ShouldReturnNotEqualToMonthlyTaxPayment()
        {
            //act
            var result = _taxCalculator.CalculateTaxPaymentPerMonth(1700000);

            //assert
            Assert.That(result, Is.Not.EqualTo(249848.666666666666667m));
        }
       
    }
}
