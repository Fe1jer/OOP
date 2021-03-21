using Laba5.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5.Models.Tasks
{
    class TaskC : IterativeConstructs
    {
        public override string GetInfo()
        {
            return "А program that flips a given integer.";
        }

        public override string Run()
        {
            int number;
            number = InputParseInt("Enter the number: ");
            return $"The inverted number looks like: {ReverseNumber(number)}";
        }

        private int ReverseNumber(int number)
        {
            int result = 0;
            bool neg = false;

            if (number < 0)
            {
                neg = true;
                number *= -1;
            }
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            if (neg) result *= -1;

            return result;
        }
    }
}
