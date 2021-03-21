using Laba5.Models.Base;

namespace Laba5.Models.Tasks
{
    public class TaskD : IterativeConstructs
    {
        public override string GetInfo()
        {
            return "A program that checks if the entered number is.";
        }

        public override string Run()
        {
            int number;
            number = InputParseInt("Enter the number: ");
            return $"Is the entered number prime: {IsPrimeNumber(number)}";
        }

        private bool IsPrimeNumber(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
