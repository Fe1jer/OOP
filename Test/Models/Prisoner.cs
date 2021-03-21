using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Models
{
    public class Prisoner
    {
        public static int count;

        public string name;
        public int period;
        public string article;

        static Prisoner()
        {
            count = 0;
        }

        public Prisoner()
        {

        }

        public Prisoner(string name, int year, string article)
        {
            this.name = name;
            this.period = year;
            this.article = article;
            count++;
        }
    }
}
