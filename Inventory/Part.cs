namespace Inventory
{
    public abstract class Part
    {
        private int _partID;
        private string _name;
        private decimal _price;
        private int _inStock;
        private int _min;
        private int _max;

        // Properties
        public int PartID
        {
            get { return _partID; }
            set { _partID = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int InStock
        {
            get { return _inStock; }
            set { _inStock = value; }
        }
        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }
        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
    }
}

