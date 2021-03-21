using Laba6.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6.Controller
{
    class MainController
    {
        public static void StartController(List<OneDimensionalArrays> programs)
        {

            int choice, i;

            while (true)
            {
                i = 1;
                foreach (OneDimensionalArrays program in programs)
                {
                    Console.WriteLine($"{i}. {program.GetInfo()}");
                    i++;
                }
                Console.WriteLine("0. Exit\n");
                choice = OneDimensionalArrays.InputParseInt("Input number of your task: ");
                if (choice == 0)
                {
                    break;
                }
                else if (choice > 0 && choice <= programs.Count)
                {
                    Console.WriteLine(programs[choice - 1].Run() + "");
                }
                else
                {
                    Console.WriteLine("Error choice");
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
