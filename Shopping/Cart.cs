namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _articleItems = new List<CartItem>();
        private int idComparator = 0;
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {

            foreach (CartItem cartItem in cartItems)
            {
                _articleItems.Add(cartItem);

                /*
                if (cartItem.Quantity > 1)
                {
                    _articleItems.Add(cartItem);
                    cartItem.Quantity -= 1;
                    _articleItems.Add(cartItem);
                }

                else
                {
                    _articleItems.Add(cartItem);
                }
                */
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

        public void Remove(List<CartItem> cartItemsToRemove)
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
                float _price = 0f;

                foreach (CartItem cartItem in _articleItems)
                {
                    _price += cartItem.Article.Price * cartItem.Quantity;
                }

                return _price;
            }

        }

        public class CartException : Exception { };
        public class EmptyCartException : CartException { };

        #endregion public methods
    }
}
