using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleList
{
    internal class Article
    {
        string title;
        string[] author;
        string content;
        DateTime publicationDate;
        DateTime lastEdit;
        int likes;
        int dislikes;

        #region Properties
        public string Title { get { return title; } set { title = value; } }
        public string[] Author { get { return author; } set { author = value; } }
        public string Content { get { return content; } set { content = value; } }
        public DateTime LastEdit { get { return lastEdit; } set { lastEdit = value; } }
        public DateTime PublicationDate { get => publicationDate; }
        public int GetLikes { get => likes; }
        public int GetDisikes { get => dislikes; }
        #endregion

        #region Constructor
        public Article(string title, string[] author, string content, DateTime publicationDate, int likes = 0, int dislikes = 0)
        {
            this.title = title;
            this.author = author;
            this.content = content;
            this.publicationDate = publicationDate;
            this.lastEdit = this.publicationDate;
            this.likes = likes;
            this.dislikes = dislikes;
        }
        #endregion
        #region Methods
        public void AddLike()
        {
            likes++;
        }
        public void RemoveLike()
        {
            if (likes > 0)
                likes--;
        }
        public void AddDisike()
        {
            dislikes++;
        }
        public void RemoveDislike()
        {
            if (likes > 0)
                likes--;
        }
        #endregion


    }
}
