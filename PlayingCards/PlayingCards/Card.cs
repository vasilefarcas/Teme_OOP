using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class Card
    {
        string rank;
        string suit;
        private Random r = new Random();
        public Card(string rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
        // generating random cards
        public Card()
        {
            int value = r.Next(2, 14);
            switch (value)
            {
                case 11: this.rank = "J"; break;
                case 12: this.rank = "Q"; break;
                case 13: this.rank = "K"; break;
                case 14: this.rank = "A"; break;
                default: this.rank = value.ToString(); break;
            }
            int tempSuit = r.Next(1, 4
                );
            switch (tempSuit)
            {
                case 1: this.suit = "Heart"; break;
                case 2: this.suit = "Diamond"; break;
                case 3: this.suit = "Club"; break;
                case 4: this.suit = "Spade"; break;
            }

        }
        public override string ToString()
        {
            return rank + " of " + suit;
        }

    }
}
