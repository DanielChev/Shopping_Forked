namespace Shopping
{
    internal interface ICollectionOfArticles
    {
        void Add(List<CartItem> cartItems);
        List<CartItem> Remove(Boolean empty = false);
        List<CartItem> CartItems { get; }
    }
}
