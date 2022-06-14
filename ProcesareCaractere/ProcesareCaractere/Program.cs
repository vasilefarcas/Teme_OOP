using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesareCaractere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextFile file = new TextFile(args[0]);
            file.viewText();
            Console.WriteLine("The number of characters including spaces: " + file.CharactersCount);
            Console.WriteLine("The number of characters without spaces: " + file.CharactersCountWithoutSpaces);
            Console.WriteLine("The number of vowels: " + file.VowelsCount);
            Console.WriteLine("The number of consonant: " + file.ConsonantCount);
            Console.WriteLine("The number of lines: " + file.LinesCount);
            Console.ReadKey();
        }
    }
}
