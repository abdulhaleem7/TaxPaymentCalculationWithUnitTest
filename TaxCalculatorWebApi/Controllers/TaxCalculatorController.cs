using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxCalculator;

namespace TaxCalculatorWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxCalculatorController : ControllerBase
    {
        private readonly ITaxCalculator _taxCalculator;
        public TaxCalculatorController(ITaxCalculator taxCalculator) => _taxCalculator = taxCalculator;

        [HttpGet("TaxPayment")]
        public IActionResult GetCalculatedTaxPayment(decimal salary)
        {
            var pension = _taxCalculator.CalCulatePension(salary * 12);
            var taxableIncome = _taxCalculator.CalculateTaxableIncome(salary);
            var taxPayment = _taxCalculator.CalculateTaxPaymentPerMonth(salary);
            var data = new { pension = pension, taxableIncome = taxableIncome, taxPayment = taxPayment };
            Console.WriteLine(data);
            return Ok(data);
        }
       

    }
}
