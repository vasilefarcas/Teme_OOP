namespace ArticleList
{
    internal class Author
    {
        string[] name;
        int numberOfArticles;
        public string[] Name { get => name; }
        public int NumberOfArticles { get => NumberOfArticles; }
        public Author(string[] name)
        {
            this.name = name;
            numberOfArticles = 0;
        }
        public void AddArticle()
        { numberOfArticles++; }
        public override string ToString()
        {
            return "";
        }
    }
}