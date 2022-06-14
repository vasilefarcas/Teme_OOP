using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    internal class UtilitiesPrototype
    {
        public static void FilterAuthor(List<ArticlePrototype> article, string author)
        {
                Console.WriteLine("The articles writen by "+author+" are:");
            foreach(ArticlePrototype articleItem in article)
            {
                //string[] authors = articleItem.author.Name;
                string[] authors = articleItem.AuthorString;
                for(int i = 0; i < authors.Length; i++)
                    if(authors[i].ToString() == author.ToString())
                        Console.WriteLine(articleItem);
            }
        }

        public static void SortByLikes(List<ArticlePrototype> list)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {

                }
            }
        }
    }
}
