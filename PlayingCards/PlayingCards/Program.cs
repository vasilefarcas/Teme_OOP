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
            deck1.view();
            deck1.Shuffle();
            deck1.view();
            
            /*
            for (int i = 0; i < 10; i++)
            {
                Card card = new Card();
                Console.WriteLine(card);
            }
            */
            Console.ReadKey();
        }
    }
}
