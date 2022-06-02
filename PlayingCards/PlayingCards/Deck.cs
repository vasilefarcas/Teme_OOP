using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class Deck
    {
        Card[] cards = new Card[53];
        private Random r = new Random();
        public Deck()
        {
            string[] value = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suit = { "Heart", "Diamond", "Club", "Spade" };
            int cardNumber = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 13; i++)
                {
                    cards[cardNumber] = new Card(value[i], suit[j]);
                    cardNumber++;
                }
            }
        }
        public void Shuffle()
        {
            bool[] used = new bool[53];
            for (int i = 0; i < 300; i++)
            {
                Switch(cards[r.Next(0, 52)], cards[r.Next(0, 52)]);
            }
        }
        public Card RandomCard() => cards[r.Next(0, 52)];
        private void Switch(Card card1, Card card2)
        {
            Card aux;
            aux = card1;
            card1 = card2;
            card2 = aux;
        }

        public void view()
        {
            for (int i = 0; i < cards.Length; i++)
                Console.WriteLine(cards[i]);
        }
    }
}
