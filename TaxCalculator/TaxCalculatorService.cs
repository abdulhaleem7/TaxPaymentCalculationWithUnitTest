using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class TaxCalculatorService
    {

        public decimal CalculateTaxableIncome(decimal salary)
        {
            if(salary <= 30000)
            {
                throw new ArgumentException("Amount is less than calculation");
            }
            salary *= 12;
            decimal pension = (8/100m) * salary;
            decimal grossIncome = salary - pension;
            decimal TwentyPercentOfGross = (20/100m) * grossIncome;
            decimal ConsolidatedReleifAllowance = 0;
            if (200000 > (1 / 100m) * salary)
            {
                ConsolidatedReleifAllowance += 200000;
            }
            else
            {
                ConsolidatedReleifAllowance += (1 / 100m) * salary;
            }
            decimal total = pension + TwentyPercentOfGross + ConsolidatedReleifAllowance;
            decimal taxableIncome = salary - total;
            return taxableIncome;
        }

        public decimal CalculateTaxPaymentPerMonth(decimal salary)
        {
             decimal amount = CalculateTaxableIncome(salary);
            decimal tax = 0;
            if(amount<= 300000)
            {
                tax = CalCulateFirst300Thousand(amount);
            }
            else if(amount > 300000 && amount<= 600000)
            {
                tax += CalCulateFirst300Thousand(300000);
                amount -= 300000;
                tax += CalculateSecond300Thousand(amount);
            }
            else if(amount >600000 && amount<= 1100000)
            {
                tax += CalCulateFirst300Thousand(300000);
                amount -= 300000;
                tax += CalculateSecond300Thousand(300000);
                amount -= 300000;
                tax += CalculateThird500Thousand(amount);
            }
            else if(amount > 1100000 && amount <= 1600000)
            {
                tax += CalCulateFirst300Thousand(300000);
                amount -= 300000;
                tax += CalculateSecond300Thousand(300000);
                amount -= 300000;
                tax += CalculateThird500Thousand(500000);
                amount -= 500000;
                tax += CalculateFourth500Thousand(amount);
            }
            else if (amount > 1600000 && amount <= 3200000)
            {
                tax += CalCulateFirst300Thousand(300000);
                amount -= 300000;
                tax += CalculateSecond300Thousand(300000);
                amount -= 300000;
                tax += CalculateThird500Thousand(500000);
                amount -= 500000;
                tax += CalculateFourth500Thousand(500000);
                amount -= 500000;
                tax += CalculateOnePointSixMillion(amount);
            }
            else if(amount > 3200000)
            {
                tax += CalCulateFirst300Thousand(300000);
                amount -=300000;
                tax += CalculateSecond300Thousand(300000);
                amount -=300000;
                tax += CalculateThird500Thousand(500000);
                amount -=500000;
                tax += CalculateFourth500Thousand(500000);
                amount -=500000;
                tax += CalculateOnePointSixMillion(1600000);
                amount -= 1600000;
                tax += CalculateThreePointTwoMillion(amount);
            }
            return tax/12;
        }
        public decimal CalCulateFirst300Thousand(decimal amount)
        {
            return (7 / 100m) * amount;
        }
        public decimal CalculateSecond300Thousand(decimal amount)
        {
            return (11 / 100m) * amount;
        }
        public decimal CalculateThird500Thousand(decimal amount)
        {
            return (15 / 100m) * amount;
        }
        public decimal CalculateFourth500Thousand(decimal amount)
        {
            return (19 / 100m) * amount;
        }
        public decimal CalculateOnePointSixMillion(decimal amount)
        {
            return (21 / 100m) * amount;
        }
        public decimal CalculateThreePointTwoMillion(decimal amount)
        {
            return (21 / 100m) * amount;
        }
    }
}
