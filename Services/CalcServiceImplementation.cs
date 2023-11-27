using vyacheslav.vorotov._932101.labs.Models;

namespace vyacheslav.vorotov._932101.labs.Services
{
    public class CalcServiceImplementation : CalcService
    {
        public string Addition(int a, int b)
        {
            return (a+b).ToString();
        }

        public string Calc(int a, int b, string operation)
        {
            switch(operation)
            {
                case "+":
                    return Addition(a, b);
                case "-":
                    return Subtracion(a, b);
                case "*":
                    return Multiplication(a, b);
                case "/":
                    return Division(a, b);
                default:
                    return "ERROR";
            }
        }

        public string Calc(CalcExpressionModel calcExpression)
        {
            return Calc(calcExpression.FirstTerm, calcExpression.SecondTerm, calcExpression.operation);
        }

        public string Division(int a, int b)
        {
            if (b == 0) return "ERROR";
            else return (a/b).ToString();
        }

        public string Multiplication(int a, int b)
        {
            return (a*b).ToString();
        }

        public string Subtracion(int a, int b)
        {
            return (a-b).ToString();
        }
    }
}