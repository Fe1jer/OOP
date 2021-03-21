using Laba4.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4.Models.Tasks
{
    /*A program that determines which of the four user-entered values ​​is the highest.
         * Possibility of equality of all values ​​is provided.*/
    public class TheGreatest : ConditionalConstructs
    {
        public override string GetInfo()
        {
            return "A program that determines which of the four user-entered values is the highest.";
        }

        public override string Run()
        {
            int num1, num2, num3, num4;

            num1 = InputParseInt("Enter the first number: ");
            num2 = InputParseInt("Enter the second number: ");
            num3 = InputParseInt("Enter the third number: ");
            num4 = InputParseInt("Enter the fourth number: ");

            return OutMaxValue(num1, num2, num3, num4);
        }

        private static string OutMaxValue(int num1, int num2, int num3, int num4)
        {
            int maxValue = num1;
            string msg = $"The first entered number is maximum: {num1}";

            if (num2 > maxValue)
            {
                maxValue = num2;
                msg = $"The second entered number is maximum: {num2}";
            }
            if (num3 > maxValue)
            {
                maxValue = num3;
                msg = $"The third entered number is maximum: {num3}";
            }
            if (num4 >= maxValue)
            {
                maxValue = num4;
                msg = $"The fourth entered number is maximum: {num4}";
                if (maxValue == num1)
                {
                    msg = "All numbers are the same";
                }
            }

            return msg;
        }
    }
}
