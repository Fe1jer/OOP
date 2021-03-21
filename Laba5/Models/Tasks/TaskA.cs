using Laba5.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5.Models.Tasks
{
    public class TaskA : IterativeConstructs
    {
        public override string GetInfo()
        {
            return "А program that finds arithmetic and geometric average of digits of a given natural number.";
        }

        public override string Run()
        {
            int number;

            number = InputParseInt("Enter the number: ");
            return $"Аrithmetic mean: {FindArithmeticMean(number)}\n" +
                $"Geometric mean: {FindGeometricMean(number)}";
        }

        private double FindArithmeticMean(int number)
        {
            double sumNumber = 0, countDigit = 0;

            while (number > 0)
            {
                sumNumber += number % 10;
                countDigit++;
                number /= 10;
            }

            return sumNumber / countDigit;
        }

        private double FindGeometricMean(int number)
        {
            int compositionNumber = 1;

            while (number > 0)
            {
                compositionNumber *= number % 10;
                number /= 10;
            }

            return Math.Sqrt(compositionNumber);
        }
    }
}
