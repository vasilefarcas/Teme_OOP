namespace ArticleList
{
    internal class AuthorPrototype
    {
        string[] name;
        int numberOfArticles;
        public string[] Name { get => name; }
        public int NumberOfArticles { get => NumberOfArticles; }
        public AuthorPrototype(string[] name)
        {
            numberOfArticles = 0;
            this.name = name;
        }
        public void AddArticle()
        { numberOfArticles++; }
        public override string ToString()
        {
            return "";
        }
    }
}