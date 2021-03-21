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
            int[] array;

            size = InputParseInt("Enter the size: ");
            array = RandomInit(size);
            PrintArray(array);

            return $"Max number: {FindMaxElem(array)}\n" +
                $"Amount to the last positive: {SumToLastPositive(array)}";
        }

        private int FindMaxElem(int[] array)
        {
            int maxNumber = array[0];

            foreach(int number in array)
            {
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            return maxNumber;
        }

        private int SumToLastPositive(int[] array)
        {
            int sum = 0;
            int k = array.Length - 1;

            while (array[k] < 0)
            {
                k--;
            }
            for (int i = 0; i < k; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
