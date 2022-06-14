using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    internal class Article
    {
        #region Fields
        string title;
        Author[] author;
        int likes;
        int dislikes;
        string content;
        DateTime publicationDate;
        DateTime lastEdit;
        #endregion
        #region Constructors
        public Article(string title, Author[] author, string content, DateTime publicationDate, int likes = 0, int dislikes = 0)
        {
            this.title = title;
            this.author = author;
            this.likes = likes;
            this.dislikes = dislikes;
            this.content = content;
            this.publicationDate = publicationDate;
            this.lastEdit = publicationDate;
        }
        #endregion
        #region Properties
        public string GetTitle { get => this.title; set { this.title = value; } }
        public string GetAuthor
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Author item in this.author)
                {
                    sb.Append($"{item.Name},");
                }
                return sb.ToString();
            }
        }
        public int NumberOfLikes { get => likes; }
        public int NumberOfDislikes { get => dislikes; }
        public string GetContent { get => content; set { content = value; } }
        public DateTime GetPublicationDate { get => publicationDate; }
        public DateTime LastEdit { get => lastEdit; set { lastEdit = value; } }
        #endregion
        #region Methods
        public void IncrementLikes()
        { likes++; }
        public void IncrementDislikes()
        { dislikes++; }
        public void DecrementLikes()
        { if (likes > 0) likes--; }
        public void DecrementDislikes()
        { if (dislikes > 0) dislikes--; }
        #endregion
        #region Overrides
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.GetTitle} written by ");
            foreach(Author item in this.author)
                sb.Append($"{item.Name} ");
            sb.Append($" and has {this.NumberOfLikes} likes.");
            return sb.ToString();
        }
        #endregion
    }
}
