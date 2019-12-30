using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Inventory
{
    public class Outsourced
    {
        
        private string _companyName;
        // Properties
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        // Constructor
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            _partID = partID;
            _name = name;
            _price = price;
            _inStock = inStock;
            _min = min;
            _max = max;
            _companyName = companyName;
        }
    }
}