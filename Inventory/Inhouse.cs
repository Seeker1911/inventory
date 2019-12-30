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
    public class Inhouse : Part
    {
        // Fields
        private int _machineID;
        // Properties
        public int MachineID
        {
            get { return _machineID; }
            set { _machineID = value; }
        }

        // Constructor

        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            _partID = partID;
            _name = name;
            _price = price;
            _inStock = inStock;
            _min = min;
            _max = max;
            _machineID = machineID;
        }     
    }
}