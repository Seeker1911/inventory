using System.ComponentModel;

namespace Inventory
{
    public class Product
    {
        protected int _productID;
        protected string _name;
        protected decimal _price;
        protected int _inStock;
        protected int _min;
        protected int _max;

        // Properties

        public static BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
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

        // Constructor
        public Product() { }

        // Overload Constructor
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            _productID = productID;
            _name = name;
            _price = price;
            _inStock = inStock;
            _min = min;
            _max = max;
        } 

        // Methods
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            bool check = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return check = true;
                }
                else check = false;
            }
            return check;
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

    }
}