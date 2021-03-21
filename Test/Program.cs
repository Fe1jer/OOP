using System;
using System.Collections.Generic;
using Test.Models;
using Test.Controllers;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Prisoner> prisoners = new List<Prisoner>()
            {
                new Prisoner("Mark", 3, "12.4"),
                new Prisoner("Viktor", 12, "4.7"),
                new Prisoner("Jo", 35, "2.8"),
                new Prisoner("Carl", 4, "1.5"),
                new Prisoner("Leonardo", 16, "11.5")
            };

            Console.WriteLine($"All Periods: {Manager.AllPeriods(prisoners)}");
            Console.WriteLine($"Max period: {Manager.FindMaxPeriod(prisoners)}");
            Console.WriteLine($"Avg period: {Manager.AvgPeriods(prisoners)}");
        }
    }
}
