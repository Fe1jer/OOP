using System;
using Laba6.Models.Base;
using Laba6.Models.Tasks;
using Laba6.Controller;
using System.Collections.Generic;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OneDimensionalArrays> programs = new List<OneDimensionalArrays>()
            {
                new Task()
            };

            MainController.StartController(programs);
        }
    }
}
