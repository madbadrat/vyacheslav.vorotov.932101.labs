using vyacheslav.vorotov._932101.labs.Models;

namespace vyacheslav.vorotov._932101.labs.Services
{
    public interface CalcService
    {
        public string Calc(int a, int b, string operation);

        public string Calc(CalcExpressionModel calcExpression);

        public string Addition(int a, int b);

        public string Subtracion(int a, int b);

        public string Multiplication(int a, int b);

        public string Division(int a, int b);
 
    }
}