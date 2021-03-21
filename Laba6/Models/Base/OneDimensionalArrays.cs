using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6.Models.Base
{
    public abstract class OneDimensionalArrays
    {
        public abstract string Run();
        public abstract string GetInfo();

        public static int InputParseInt(string msg)
        {
            int number;

            while (true)
            {
                string input;

                Console.WriteLine(msg);
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if(number >= 0)
                    {
                        break;
                    }
                }
            }

            return number;
        }

        public static int[] RandomInit(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-50, 50);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            string msg = "Array: ";
            foreach (int number in array)
            {
                msg += number.ToString() + " ";
            }
            Console.WriteLine(msg);
        }
    }
}
