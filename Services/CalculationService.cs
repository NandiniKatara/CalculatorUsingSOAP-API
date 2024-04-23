using CalculatorUsingSOAP.Models;
using static CalculatorUsingSOAP.Controllers.CalculationsController;

namespace CalculatorUsingSOAP.Services
{
    public class CalculationService : InterfaceCalculator
    {
        public void SetNumbers(double n1, double n2)
        {
            CalculationDataContract obj = new CalculationDataContract
            {
                number1 = n1,
                number2 = n2,
                FinalResult = 0
            };
        }

        public double CalculateAddition(double number1, double number2)
        {
            var result = number1 + number2;
            return result;
        }

        public double CalculateSubtraction(double number1, double number2)
        {
            var result = number1 - number2;
            return result;
        }

        public double CalculateMultiplication(double number1, double number2)
        {
            var result = number1 * number2;
            return result;
        }

        public double CalculateDivision(double number1, double number2)
        {
            var result = number1 / number2;
            return result;
        }
    }
}
