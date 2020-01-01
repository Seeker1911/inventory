namespace Inventory
{
    public class Part
    {
        
        protected int _partID;
        protected string _name;
        protected decimal _price;
        protected int _inStock;
        protected int _min;
        protected int _max;

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