using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProcesareCaractere
{
    internal class TextFile
    {
        string[] text = new string[10];
        int numberOfLines = 0;
        #region Properties
        public int CharactersCount
        {
            get
            {
                int numberOfChararcters = 0;
                for (int i = 0; i < numberOfLines; i++)
                {
                    numberOfChararcters += text[i].Length;
                }
                return numberOfChararcters;
            }
        }
        public int CharactersCountWithoutSpaces
        {
            get
            {
                int numberOfCharacters = this.CharactersCount;
                for (int i = 0; i < numberOfLines; i++)
                {
                    int length = text[i].Length;
                    for (int j = 0; j < length; j++)
                    {
                        if (text[i][j] == ' ')
                            numberOfCharacters--;
                    }
                }
                return numberOfCharacters;
            }
        }
        public int VowelsCount
        {
            get
            {
                int vowelsCount = 0;
                string vowels = "aeiouAEIOU";
                for (int i = 0; i < numberOfLines; i++)
                {
                    int length = text[i].Length;
                    for (int j = 0; j < length; j++)
                    {
                        if (vowels.IndexOf(text[i][j]) != -1)
                            vowelsCount++;
                    }
                }
                return vowelsCount;
            }
        }
        public int ConsonantCount
        {
            get => CharactersCountWithoutSpaces - VowelsCount;
        }
        public int LinesCount { get => numberOfLines; }
        #endregion
        #region Constructor
        public TextFile(string path)
        {
            TextReader load = new StreamReader(path);
            string linie;
            // load.ReadToEnd();
            while ((linie = load.ReadLine()) != null)
            {
                text[numberOfLines] = linie;
                numberOfLines++;
            }
        }
        #endregion
        #region Methods
        public void viewText()
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
        #endregion
    }
}
