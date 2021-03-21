using Laba5.Models.Base;
using System;
using System.Collections.Generic;

namespace Laba5.Controller
{
    public class MainController
    {
        public static void StartController(List<IterativeConstructs> programs)
        {

            int choice, i;

            while (true)
            {
                i = 1;
                foreach (IterativeConstructs program in programs)
                {
                    Console.WriteLine($"{i}. {program.GetInfo()}");
                    i++;
                }
                Console.WriteLine("0. Exit\n");
                choice = IterativeConstructs.InputParseInt("Input number of your task: ");
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
