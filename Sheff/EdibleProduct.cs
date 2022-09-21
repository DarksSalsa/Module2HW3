namespace Sheff
{
    public abstract class EdibleProduct
    {
        private string _name;

        public EdibleProduct(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
