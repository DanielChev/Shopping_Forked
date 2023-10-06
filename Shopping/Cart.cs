using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            foreach (Article article in articles)
            {
                _articles.Add(article);
            }
        }

        public List<Article> Remove(bool clearCart = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();

            if (clearCart) 
            {
                articlesReadyToCheckout.Clear();
                return articlesReadyToCheckout;
            }
            else
            {
                foreach(Article article in _articles)
                {
                    articlesReadyToCheckout.Remove(article);
                }
                return articlesReadyToCheckout;
            }
        }

        public void Release()
        {
            IsReleased = true;
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public bool? IsReleased { get; set; }

        public class CartException : Exception { };
        public class EmptyCartException : CartException { };

        #endregion public methods
    }
}
