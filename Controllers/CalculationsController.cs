using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace CalculatorUsingSOAP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationsController : Controller
    {
        [HttpGet("{number1:double} + {number2:double}")]
        public async Task<double> CalculateAdditionAsync(double number1, double number2)
        {
            InterfaceCalculator calc = new InterfaceCalculatorClient(InterfaceCalculatorClient.EndpointConfiguration.BasicHttpBinding_InterfaceCalculator);
            return await calc.CalculateAdditionAsync(number1, number2);
        }

        [HttpGet("{number1:double} - {number2:double}")]
        public async Task<double> CalculateSubtractionAsync(double number1, double number2)
        {
            InterfaceCalculator calc = new InterfaceCalculatorClient(InterfaceCalculatorClient.EndpointConfiguration.BasicHttpBinding_InterfaceCalculator);
            return await calc.CalculateSubtractionAsync(number1, number2);
        }

        [HttpGet("{number1:double} * {number2:double}")]
        public async Task<double> CalculateMultiplicationAsync(double number1, double number2)
        {
            InterfaceCalculator calc = new InterfaceCalculatorClient(InterfaceCalculatorClient.EndpointConfiguration.BasicHttpBinding_InterfaceCalculator);
            return await calc.CalculateMultiplicationAsync(number1, number2);
        }

        [HttpGet("{number1:double} / {number2:double}")]
        public async Task<IActionResult> CalculateDivisionAsync(double number1, double number2)
        {
            if (number2 == 0)
            {
                return StatusCode(400, "Bad Request: Division by zero is not allowed.");
            }

            try
            {
                InterfaceCalculator calc = new InterfaceCalculatorClient(InterfaceCalculatorClient.EndpointConfiguration.BasicHttpBinding_InterfaceCalculator);
                double result = await calc.CalculateDivisionAsync(number1, number2);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Cannot divide by 0");
            }
        }
    }
}
