using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Test.Controllers
{
    public class Manager
    {
        public static int FindMaxPeriod(List<Prisoner> prisoners)
        {
            int maxPeriod = 0;

            foreach(Prisoner prisoner in prisoners)
            {
                if(prisoner.period > maxPeriod)
                {
                    maxPeriod = prisoner.period;
                }
            }

            return maxPeriod;
        }

        public static int AllPeriods(List<Prisoner> prisoners)
        {
            int allPeriods = 0;

            foreach (Prisoner prisoner in prisoners)
            {
                allPeriods += prisoner.period;
            }

            return allPeriods;
        }

        public static int AvgPeriods(List<Prisoner> prisoners)
        {
            int allPeriods = 0;

            foreach (Prisoner prisoner in prisoners)
            {
                allPeriods += prisoner.period;
            }

            return allPeriods/prisoners.Count;
        }
    }
}
