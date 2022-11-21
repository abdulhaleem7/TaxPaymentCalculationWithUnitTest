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
        [Test]
        public void Calculate_Taxable_Income()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxableIncome(543000m);

            //assert
            Assert.That(result, Is.EqualTo(4595776.000m));
        }
        [Test]
        public void Calculate_Taxable_Income_For_6890000()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxableIncome(6890000);

            //assert
            Assert.That(result, Is.EqualTo(60025680.000m));
        }
        [Test]
        public void Calculate_Taxable_Income_For_400000()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxableIncome(400000);

            //assert
            Assert.That(result, Is.EqualTo(3332800.000m));
        }
         [Test]
         public void Calculate_Taxable_Income_For_LessThanZero()
         {
             //Arrange
             var taxableIncome = new TaxCalculatorService();

             //assert
             Assert.Throws<ArgumentException>(()=> taxableIncome.CalculateTaxableIncome(30000));
         }
        [Test]
        public void Calculate_Monthly_Tax_Payment()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxPaymentPerMonth(900000);

            //assert
            Assert.That(result, Is.EqualTo(126270.66666666666666666666667m));
        }
        [Test]
        public void Calculate_Monthly_Tax_Payment_For_6890000()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxPaymentPerMonth(6890000);

            //assert
            Assert.That(result, Is.EqualTo(1041116.0666666666666666666667m));
        }
        [Test]
        public void Calculate_Monthly_Tax_Payment_For_400000()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxPaymentPerMonth(400000);

            //assert
            Assert.That(result, Is.EqualTo(48990.666666666666666666666667m));
        }
        [Test]
        public void Calculate_Monthly_Tax_Payment_For_1700000()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxPaymentPerMonth(1700000);

            //assert
            Assert.That(result, Is.EqualTo(249848.66666666666666666666667m));
        }
        [Test]
        public void Calculate_Taxable_Income_For_LessThanZero2()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //assert
            Assert.Throws<ArgumentException>(() => taxableIncome.CalculateTaxPaymentPerMonth(30000));
        }
        public void Calculate_Monthly_Tax_Payment_For_6890000_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxPaymentPerMonth(6890000);

            //assert
            Assert.That(result, Is.Not.EqualTo(141116.0666666666666666666667m));
        }
        [Test]
        public void Calculate_Monthly_Tax_Payment_For_400000_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxPaymentPerMonth(400000);

            //assert
            Assert.That(result, Is.Not.EqualTo(4990.666666666666666666666667m));
        }
        [Test]
        public void Calculate_Monthly_Tax_Payment_For_1700000_Not_Equal_To_Answer()
        {
            //Arrange
            var taxableIncome = new TaxCalculatorService();

            //act
            var result = taxableIncome.CalculateTaxPaymentPerMonth(1700000);

            //assert
            Assert.That(result, Is.Not.EqualTo(249848.666666666666667m));
        }
       
    }
}
