using System.ServiceModel;

namespace CalculatorUsingSOAP.Models
{
    // Defining the service contract InterfaceCalculator
    [ServiceContract]
    public interface InterfaceCalculator
    {
        // Operation contract to set the numbers for calculation
        [OperationContract]
        void SetNumbers(double number1, double number2);

        // Operation contract for add, sub, multiply, divide
        [OperationContract]
        double CalculateAddition(double number1, double number2);
        
        [OperationContract]
        double CalculateSubtraction(double number1, double number2);
       
        [OperationContract]
        double CalculateMultiplication(double number1, double number2);
       
        [OperationContract]
        double CalculateDivision(double number1, double number2);
    }
}
