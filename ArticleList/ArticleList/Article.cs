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
        // public Author[] author;
        string[] authorString;
        string content;
        DateTime publicationDate;
        DateTime lastEdit;
        int likes;
        int dislikes;
        #endregion
        #region Properties
        public string Title { get { return title; } set { title = value; } }
        //public Author[] Author { get { return author; } set { author = value; } }
        public string[] AuthorString { get { return authorString; } set { authorString = value; } }

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
            this.authorString = author;
            this.content = content;
            this.publicationDate = publicationDate;
            this.lastEdit = this.publicationDate;
            this.likes = likes;
            this.dislikes = dislikes;
            //foreach (Author item in author)
            //  item.AddArticle();
        }
        #endregion
        #region Methods
        public string GetAuthorsText()
        {
            StringBuilder sb = new StringBuilder();
            //foreach (Author item in this.author)
            //   sb.Append(item + ", ");
            foreach (string item in authorString)
                sb.Append(item + ", ");
            return sb.ToString();
        }
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
        #region Overrides
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("The article ");
            stringBuilder.Append(this.title);
            stringBuilder.Append(" written by ");
            stringBuilder.Append(GetAuthorsText());
            stringBuilder.Append(" with the content: ");
            stringBuilder.Append(this.content);
            return stringBuilder.ToString();
        }
        #endregion
    }
}
