using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public interface ITaxCalculator
    {
        public decimal CalCulatePension(decimal amount);
        public decimal CalculateTaxableIncome(decimal salary);
        public decimal CalculateTaxPaymentPerMonth(decimal salary);
        public decimal CalCulateFirst300Thousand(decimal amount);
        public decimal CalculateSecond300Thousand(decimal amount);
        public decimal CalculateThird500Thousand(decimal amount);
        public decimal CalculateFourth500Thousand(decimal amount);
        public decimal CalculateOnePointSixMillion(decimal amount);
        public decimal CalculateThreePointTwoMillion(decimal amount);
    }
}
