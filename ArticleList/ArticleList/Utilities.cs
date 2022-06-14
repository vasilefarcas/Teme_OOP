using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    internal class Utilities
    {
        public static void FilterAuthor(List<Article> list, Author author)
        {
            Console.WriteLine($"The articles that contain {author.Name} are:");
            foreach (Article article in list)
            {
                string[] autori = article.GetAuthor.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string autor in autori)
                    if (autor == author.Name)
                    {
                        Console.WriteLine(article);
                        break;
                    }
            }
        }
        public static void View<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void SortDescendingByLikes(List<Article> list)
        {
            Console.WriteLine("The list of articles sorted descending by the number of likes:");
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i].NumberOfLikes < list[j].NumberOfLikes)
                        Swap(ref list, i, j);
                }
            }
            View(list);
        }
        public static void SortAscendingByLikes(List<Article> list)
        {
            Console.WriteLine("The list of articles sorted ascending by the number of likes:");
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].NumberOfLikes > list[j].NumberOfLikes)
                        Swap(ref list, i, j);
                }
            }
            View(list);
        }
        public static void ShowArticlesInInterval(List<Article> list, DateTime dateStart, DateTime dateEnd)
        {
            Console.WriteLine($"The articles published between {dateStart} and {dateEnd}");
            foreach (Article item in list)
            {
                if (item.GetPublicationDate>dateStart && item.GetPublicationDate<dateEnd)
                    Console.WriteLine(item);
            }
        }
        public static void Swap<T>(ref List<T> list, int index1, int index2)
        {
            T aux = list[index1];
            list[index1] = list[index2];
            list[index2] = aux;
        }
    }
}
