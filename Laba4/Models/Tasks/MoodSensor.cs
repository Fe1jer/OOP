using Laba4.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4.Models.Tasks
{
    public class MoodSensor : ConditionalConstructs
    {
        public override string GetInfo()
        {
            return "A program that determines your mood in the current moment of time.";
        }

        public override string Run()
        {
            return "Your mood: " + RandomMood();
        }

        private string RandomMood()
        {
            Random random = new Random();
            Console.OutputEncoding = Encoding.UTF8;
            List<string> msg = new List<string>() { "(╮°-°)╮┳━━┳ ( ╯°□°)╯ ┻━━┻", "(っ˘ڡ˘ς)", "¯\\_(ツ)_/¯", "0_0", "(｡❤‿❤｡)" };
            int i = random.Next(0, msg.Count);
            return msg[i];
        }
    }
}
