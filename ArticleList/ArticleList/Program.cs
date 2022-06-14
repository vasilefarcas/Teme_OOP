using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<ArticlePrototype> list = new List<ArticlePrototype>();
            list.Add(new ArticlePrototype("Great Depresion", new string[] { "Ray Dalio", "Nassim Taleb" }, "It was a black day on the market.", new DateTime(1930, 12, 19), 20, 15));
            list.Add(new ArticlePrototype("Great Depresion2", new string[] { "Ray Dalio1", "Nassim Taleb2" }, "It was a black day on the market.", new DateTime(1933, 12, 19), 19, 18));
            list.Add(new ArticlePrototype("Great Depresion3", new string[] { "Ray Dalio2", "Nassim Taleb3" }, "It was a black day on the market.", new DateTime(1940, 12, 19), 10, 0));
            list.Add(new ArticlePrototype("Great Depresion4", new string[] { "Ray Dalio1", "Nassim Taleb6" }, "It was a black day on the market.", new DateTime(1932, 12, 19), 5, 5));
            list.Add(new ArticlePrototype("Great Depresion5", new string[] { "Ray Dalio1", "Nassim Taleb" }, "It was a black day on the market.", new DateTime(1930, 10, 19), 30, 1));
            UtilitiesPrototype.FilterAuthor(list, "Ray Dalio2");
            UtilitiesPrototype.FilterAuthor(list, "Ray Dalio1");
            */
            List<Article> truelist = new List<Article>();
            truelist.Add(new Article("Great Depresion", new Author[] { new Author("Ray Dalio"), new Author("Nassim Taleb") }, "It was a black day on the market.", new DateTime(1930, 12, 19), 11, 15));
            truelist.Add(new Article("Great Depresion2", new Author[] { new Author("Ray Dalio1"), new Author("Nassim Taleb2") }, "It was a black day on the market.", new DateTime(1935, 12, 19), 25, 15));
            truelist.Add(new Article("Great Depresion3", new Author[] { new Author("Ray Dalio2"), new Author("Nassim Taleb1") }, "It was a black day on the market.", new DateTime(1931, 12, 19), 20, 15));
            truelist.Add(new Article("Great Depresion4", new Author[] { new Author("Ray Dalio1"), new Author("Nassim Taleb1") }, "It was a black day on the market.", new DateTime(1932, 12, 19), 5, 15));
            truelist.Add(new Article("Great Depresion5", new Author[] { new Author("Ray Dalio") }, "It was a black day on the market.", new DateTime(1940, 12, 19), 13, 15));
            Utilities.FilterAuthor(truelist, new Author("Ray Dalio"));
            Console.WriteLine();
            Utilities.View(truelist);
            Console.WriteLine();
            Utilities.SortDescendingByLikes(truelist);
            Console.WriteLine();
            Utilities.SortAscendingByLikes(truelist);
            Console.WriteLine();
            Utilities.ShowArticlesInInterval(truelist, new DateTime(1929, 10, 05), new DateTime(1931, 12, 10));
            Console.ReadKey();
        }

    }
}
