using Laba4.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4.Models.Tasks
{
    public class PlayingCards : ConditionalConstructs
    {
        public override string GetInfo()
        {
            return "Displays the name of the corresponding card in the form: six of diamonds, queen of hearts, ace of clubs, etc:";
        }

        public override string Run()
        {
            Random random = new Random();

            Console.WriteLine("A card and suit are generated...");
            int indexAdvantage = random.Next(1, 4);
            int indexSuits = random.Next(6, 14);

            return RandomCard(indexAdvantage, indexSuits);
        }

        private string RandomCard(int indexAdvantage, int indexSuits)
        {
            Dictionary<int, string> cardSuits = new Dictionary<int, string>
            {
                { 1, "peaks" },
                { 2, "club" },
                { 3, "diamond"},
                { 4, "hearts"}
            };
            Dictionary<int, string> cardAdvantage = new Dictionary<int, string> {
                { 6, "Six" },
                { 7, "Seven"},
                { 8, "Eight"},
                { 9, "Nine"},
                { 10, "Ten"},
                { 11, "Jack"},
                { 12, "Queen"},
                { 13, "King"},
                { 14, "Ace"},
            };

            return $"{cardAdvantage[indexSuits]} {cardSuits[indexAdvantage]}";
        }
    }
}
