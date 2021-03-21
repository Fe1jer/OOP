using Laba5.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5.Models.Tasks
{
    public class TaskB : IterativeConstructs
    {
        public override string GetInfo()
        {
            return "A program that checks that among the digits of a given natural number there are at least one pair of coinciding";
        }

        public override string Run()
        {
            int number;
            number = InputParseInt("Enter the number: ");
            return $"Are there any overlapping numbers: {IsNumbersMatch(number)}";
        }

        private bool IsNumbersMatch(int number)
        {
            int digit, tempNumber;
            while (number > 0)
            {
                digit = number % 10;
                tempNumber = number / 10;
                while (tempNumber > 0)
                {
                    if (digit == tempNumber % 10)
                    {
                        return true;
                    }
                    tempNumber /= 10;
                }
                number /= 10;
            }
            return false;
        }
    }
}
