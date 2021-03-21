using Laba5.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5.Models.Tasks
{
    public class TaskE : IterativeConstructs
    {
        public override string GetInfo()
        {
            return "А program that finds all the elements of that part of the Fibonacci number sequence, the value of the last element of which does not exceed the value entered by the user values.";
        }

        public override string Run()
        {
            int number;
            number = InputParseInt("Enter the number: ");
            return $"Fibonacci series: {string.Join( ", ", FibonacciToNumber(number))}";
        }

        private List<int> FibonacciToNumber(int number)
        {
            int prev = 0;
            int current = 1;
            int temp;
            List<int> numbers = new List<int>();

            Console.WriteLine(prev);
            for (int i = 0; current <= number; i++)
            {
                numbers.Add(current);
                temp = current;
                current = current + prev;
                prev = temp;
            }

            return numbers;
        }
    }
}
