using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<CartItem> _articleItems = new List<CartItem>();
        private float _price;
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _articleItems.AddRange(cartItems);

            for (int i = 0; i < CartItems.Count(); i++)
            {
                _price += cartItems[i].Article.Price;
            }

        }

        public List<CartItem> Remove(Boolean clearCart = false)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> Remove(CartItem cartItemToRemove)
        {
            throw new NotImplementedException();
        }

        public void Release()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _articleItems;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }

        public bool? IsReleased { get; set; }

        public class CartException : Exception { };
        public class EmptyCartException : CartException { };

        #endregion public methods
    }
}
