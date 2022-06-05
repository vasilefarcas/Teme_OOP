using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class Card
    {
        int rank;
        string suit;
        private Random r = new Random();
        internal int Rank
        {
            get { return rank; }
            set
            {
                if (value >= 2 && value <= 14)
                    rank = value;
            }
        }
        internal string Suit
        {
            get { return suit; }
            set { suit = value; }
        }
        public string Text
        {
            get
            {
                string tempRank;
                switch (this.rank)
                {
                    case 11: tempRank = "J"; break;
                    case 12: tempRank = "Q"; break;
                    case 13: tempRank = "K"; break;
                    case 14: tempRank = "A"; break;
                    default: tempRank = this.rank.ToString(); break;
                }
                return tempRank + " of " + suit;
            }
        }
        public Card(int rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
        // generating random cards
        public Card()
        {
            this.rank = r.Next(2, 14);
            int tempSuit = r.Next(1, 4);
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
            return this.Text;
        }
        public static bool operator >(Card card1, Card card2) => card1.rank > card2.rank;
        public static bool operator <(Card card1, Card card2) => card1.rank < card2.rank;
        public static bool operator ==(Card card1, Card card2) => card1.rank == card2.rank && card1.suit == card2.suit;
        public static bool operator !=(Card card1, Card card2) => card1.rank != card2.rank || card1.suit != card2.suit;

    }
}
