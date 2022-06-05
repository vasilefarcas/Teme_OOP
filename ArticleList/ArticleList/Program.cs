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
            List<Article> list = new List<Article>();
            list.Add(list[0] = new Article("Great Depresion", new string[] { "Ray Dalio", "Nassim Taleb" }, "It was a black day on the market.", new DateTime(1930, 12, 19), 20, 15));
            list.Add(list[1] = new Article("Great Depresion2", new string[] { "Ray Dalio1", "Nassim Taleb2" }, "It was a black day on the market.", new DateTime(1933, 12, 19), 19, 18));
            list.Add(list[2] = new Article("Great Depresion3", new string[] { "Ray Dalio2", "Nassim Taleb3" }, "It was a black day on the market.", new DateTime(1940, 12, 19), 10, 0));
            list.Add(list[3] = new Article("Great Depresion4", new string[] { "Ray Dalio1", "Nassim Taleb6" }, "It was a black day on the market.", new DateTime(1932, 12, 19), 5, 5));
            list.Add(list[4] = new Article("Great Depresion5", new string[] { "Ray Dalio1", "Nassim Taleb" }, "It was a black day on the market.", new DateTime(1930, 10, 19), 30, 1));
        }
    }
}
