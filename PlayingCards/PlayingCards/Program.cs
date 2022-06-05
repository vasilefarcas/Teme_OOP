using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            Console.WriteLine("Inainte de shuffle.");
            deck1.view();
            deck1.Shuffle();
            Console.WriteLine("\n\n\n\nDupa shuffle.\n\n\n\n");
            deck1.view();
            Console.WriteLine("\n\n\n\nSe extrag pe rand carti.\n\n\n\n");
            for (int i = 0; i < 53; i++)
            {
                Console.WriteLine(deck1.GetRandomCard() + " " + deck1.CardsLeft);
            }
            Console.ReadKey();
        }
    }
}

