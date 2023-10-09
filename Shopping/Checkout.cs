namespace Shopping
{
    public class Checkout
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private float _balance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            foreach (Article article in articles)
            {
                _articles.Add(article);
                _balance += article.Price;
            }
        }

        public List<Article> Remove(Boolean empty = false)
        {
            List<Article> removedArticles = new List<Article>();

            if (empty)
            {
                removedArticles.AddRange(_articles);
                _articles.Clear();
            }
            else
            {
                Article removedArticle = _articles[_articles.Count - 1];
                _articles.RemoveAt(_articles.Count - 1);
                removedArticles.Add(removedArticle);
            }
            return removedArticles;
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public float Balance
        {
            get
            {
                return _balance;
            }
        }

        public void StartCashingProcess()
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                throw new NotImplementedException();
            }
        }
        #endregion private methods
    }
}
