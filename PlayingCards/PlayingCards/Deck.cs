using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class Deck
    {
        Card[] cards = new Card[52];
        bool[] used = new bool[52];
        int countUsed = 0;
        private Random r = new Random();
        #region Properties
        public int CardsLeft { get { return 52 - countUsed; } }
        #endregion
        #region Constructor
        public Deck()
        {
            string[] suit = { "Heart", "Diamond", "Club", "Spade" };
            int cardNumber = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 2; i < 15; i++)
                {
                    cards[cardNumber] = new Card(i, suit[j]);
                    cardNumber++;
                }
            }
        }
        #endregion
        #region Methods
        public void Shuffle()
        {
            bool[] used = new bool[53];
            for (int i = 0; i < 1000; i++)
            {
                Switch(cards[r.Next(0, 52)], cards[r.Next(0, 52)]);
            }
        }
        public Card GetRandomCard()
        {
            int position = r.Next(0, 52);
            while (used[position] == true)
                position = r.Next(0, 52);
            countUsed++;
            used[position] = true;
            return cards[position];
        }
        private void Switch(Card card1, Card card2)
        {
            Card aux = new Card();
            aux.Rank = card1.Rank;
            aux.Suit = card1.Suit;
            card1.Rank = card2.Rank;
            card1.Suit = card2.Suit;
            card2.Rank = aux.Rank;
            card2.Suit = aux.Suit;
        }

        public void view()
        {
            for (int i = 0; i < cards.Length; i++)
                Console.WriteLine(cards[i].Text);
        }
        #endregion
    }
}
