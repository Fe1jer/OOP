using System;
using System.Collections.Generic;
using Laba4.Controller;
using Laba4.Models.Base;
using Laba4.Models.Tasks;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ConditionalConstructs> programs = new List<ConditionalConstructs>() 
            { 
                new Dragon(),
                new Multiplicity(), 
                new TheGreatest(), 
                new MoodSensor() ,
                new PlayingCards()
            };
            MainController.StartController(programs);
        }
    }
}
