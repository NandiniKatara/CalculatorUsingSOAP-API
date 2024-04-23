using System.Runtime.Serialization;

namespace CalculatorUsingSOAP.Models
{
    [DataContract]
    public class CalculationDataContract
    {
        [DataMember]
        public double number1 { get; set; }

        [DataMember]
        public double number2 { get; set; }

        [DataMember]
        public double FinalResult { get; set; }

    }
}
