namespace vyacheslav.vorotov._932101.labs.Models
{
    public class CalcModel
    {
        public double FirstTerm {get;set;}
        public double SecondTerm {get;set;}

        public CalcModel()
        {
            Random random = new Random();
            int _FirstTerm = random.Next(0,11);
            int _SecondTerm = random.Next(0,11);

            FirstTerm = Convert.ToDouble(_FirstTerm);
            SecondTerm = Convert.ToDouble(_SecondTerm);
            // SecondTerm = 0;
        }
    }
}