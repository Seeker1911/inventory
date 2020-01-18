namespace Inventory
{
    public class Outsourced : Part
    {
        private string _companyName;
        // Properties
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        // Constructor
        public Outsourced(int partId, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public Outsourced(int partId, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}