using vyacheslav.vorotov._932101.labs.Models;

namespace vyacheslav.vorotov._932101.labs.Services
{
    public class CalculationServiceImplementation : CalculationService
    {
        Random random = new Random();

        public int getNumber()
        {
            return random.Next(0,11);
        }
        public string addition(double a, double b)
        {
            return (a+b).ToString();
        }

        public string subtraction(double a, double b)
        {
            return (a-b).ToString();
        }

        public string multiplication(double a, double b)
        {
            return (a*b).ToString();
        }

        public string division(double a, double b)
        {
            if (b==0) return "ERROR";
            else return (a/b).ToString();
        }
    }    
}