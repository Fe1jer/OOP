using Laba4.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4.Controller
{
    public class MainController
    {
        public static void StartController(List<ConditionalConstructs> programs)
        {
            int choice, i;

            while (true)
            {
                i = 1;
                foreach (ConditionalConstructs program in programs)
                {
                    Console.WriteLine($"{i}. {program.GetInfo()}");
                    i++;
                }
                Console.WriteLine("0. Exit\n");
                choice = ConditionalConstructs.InputParseInt("Input number of your task: ");
                if (choice == 0)
                {
                    break;
                }
                else if (choice > 0 && choice <= programs.Count)
                {
                    Console.WriteLine(programs[choice - 1].Run() + "\n");
                }
                else
                {
                    Console.WriteLine("Error choice\n");
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
