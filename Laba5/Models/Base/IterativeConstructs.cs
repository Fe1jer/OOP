using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5.Models.Base
{
    public abstract class IterativeConstructs
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
                    break;
                }
            }

            return number;
        }
    }
}
