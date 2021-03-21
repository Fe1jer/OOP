using Laba4.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4.Models.Tasks
{
    //the program that determines if the entered number is multiple of the following numbers 2, 3, 5, 7, 11, 13, 17 and 19.

    class Multiplicity : ConditionalConstructs
    {
        public override string GetInfo()
        {
            return "The program that determines if the entered number is multiple of the following numbers 2, 3, 5, 7, 11, 13, 17 and 19.";
        }

        public override string Run()
        {
            int num;

            num = InputParseInt("Enter the number: ");

            return MultiplicityOfNumbers(num);
        }

        private static string MultiplicityOfNumbers(int num)
        {
            string msg = "The entered number is a multiple of 2, 3, 5, 7, 11, 13, 17 and 19: ";
            if ((num % 2) == 0 || (num % 3) == 0 ||
                (num % 5) == 0 || (num % 7) == 0 ||
                (num % 11) == 0 || (num % 13) == 0 ||
                (num % 17) == 0 || (num % 19) == 0)
            {
                msg += "True";
            }
            else
            {
                msg += "False";
            }
            return msg;
        }
    }
}
