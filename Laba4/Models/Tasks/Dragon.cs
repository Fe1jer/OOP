using Laba4.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4.Models.Tasks
{
    //a program that calculates how many goals and the eye of a dragon that is N years old.
    class Dragon : ConditionalConstructs
    {
        public override string GetInfo()
        {
            return "А program that calculates how many goals and the eye of a dragon that is N years old.";
        }

        public override string Run()
        {
            int years, heads;

            years = InputParseInt("Enter the N years: ");
            heads = CountHeads(years);
            return $"Count heads = {heads}, count eyes = {CountEyes(heads)}";
        }

        private static int CountEyes(int head)
        {
            return head * 2;
        }

        private static int CountHeads(int years)
        {
            const int STARTHEAD = 3, THREEHEADS = 3, TWOHEADS = 2;
            const int twoHundredYear = 200, threeHundredYear = 300;
            int head;

            if (years < twoHundredYear && years > 0)
            {
                head = years * THREEHEADS + STARTHEAD;
            }
            else if (years >= twoHundredYear && years < threeHundredYear)
            {
                head = twoHundredYear * THREEHEADS + (years - twoHundredYear) * TWOHEADS + STARTHEAD;
            }
            else if (years >= threeHundredYear)
            {
                head = twoHundredYear * THREEHEADS + (threeHundredYear - twoHundredYear) * TWOHEADS + (years - threeHundredYear) + STARTHEAD;
            }
            else
            {
                throw new ArgumentException("Error, incorrect data, input number more than 0.");
            }

            return head;
        }
    }
}
