using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    internal class Author
    {
        private string name;
        int numberOfArticles;
        public string Name { get => this.name; }
        public int NumberOfArticles { get => numberOfArticles; }
        public Author(string Name)
        {
            this.name = Name;
            this.numberOfArticles = 0;
        }
        public void AddArticle()
        {
            this.numberOfArticles++;
        }
        public override string ToString()
        {
            return $"{this.name} who wrote {numberOfArticles} articles.";
        }
    }
}
