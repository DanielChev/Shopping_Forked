namespace Shopping
{
    public class Article
    {
        #region private attributes
        private int _id;
        private string _description = "";
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(int id, string description, float price)
        {
            _price = price;
            _id = id;
            _description = description;
        }


        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                string descToCheck = value;
                float maxSize = 50;
                char[] specialChars = { '!', '*', '+', '/' };

                foreach (char specialChar in specialChars)
                {
                    if (descToCheck.Contains(specialChar))
                    {
                        throw new SpecialCharInDescriptionException();
                    }
                }

                //La description doit contenir au moins un espace
                if (!descToCheck.Contains(' '))
                {
                    throw new TooShortDescriptionException();
                }

                if (descToCheck.Length > maxSize)
                {
                    throw new TooLongDescriptionException();
                }

                _description = value;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }
        #endregion public methods

        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
