using Laba6.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6.Models.Tasks
{
    public class Task : OneDimensionalArrays
    {
        public override string GetInfo()
        {
            return "А program that finds arithmetic and geometric average of digits of a given natural number.";
        }

        public override string Run()
        {
            int size;
            int[] numbers;

            size = InputParseInt("Enter the number: ");
            numbers = new int[size];

            return $"Аrithmetic mean: {FindArithmeticMean(numbers)}\n" +
                $"Geometric mean: {FindGeometricMean(numbers)}";
        }
    }
}
