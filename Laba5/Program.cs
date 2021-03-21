using System;
using System.Collections.Generic;
using Laba5.Controller;
using Laba5.Models.Base;
using Laba5.Models.Tasks;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IterativeConstructs> programs = new List<IterativeConstructs>()
            {
                new TaskA(),
                new TaskB(),
                new TaskC(),
                new TaskD(),
                new TaskE()
            };

            MainController.StartController(programs);
        }
    }
}
