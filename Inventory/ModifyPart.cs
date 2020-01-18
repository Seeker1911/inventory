using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{

    public partial class ModifyPart: Form
    {
        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(Inhouse inhouse)
        {
            InitializeComponent();
            
            IDTextBox.Text = Convert.ToString(inhouse.PartID);
            NameTextBox.Text = inhouse.Name;
            InventoryTextBox.Text = Convert.ToString(inhouse.InStock);
            PriceCostTextBox.Text = Convert.ToString(inhouse.Price);
            MinTextBox.Text = Convert.ToString(inhouse.Min);
            MaxTextBox.Text = Convert.ToString(inhouse.Max);
            IdentifierLabelTextBox.Text = Convert.ToString(inhouse.MachineID);
            IdentifierLabel.Text = "Machine ID";
            InhouseRadio.Checked = true;
        }

        public ModifyPart(Outsourced outsourced)
        {
            InitializeComponent();

            IDTextBox.Text = Convert.ToString(outsourced.PartID);
            NameTextBox.Text = outsourced.Name;
            InventoryTextBox.Text = Convert.ToString(outsourced.InStock);
            PriceCostTextBox.Text = Convert.ToString(outsourced.Price);
            MinTextBox.Text = Convert.ToString(outsourced.Min);
            MaxTextBox.Text = Convert.ToString(outsourced.Max);
            IdentifierLabelTextBox.Text = Convert.ToString(outsourced.CompanyName);
            IdentifierLabel.Text = "Company Name";
            OutsourcedRadio.Checked = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
   
            if (InhouseRadio.Checked)
            {
                InhouseRadio.Checked = true;

                // verify fields are not null
                if (String.IsNullOrWhiteSpace(IDTextBox.Text) || String.IsNullOrWhiteSpace(NameTextBox.Text) || String.IsNullOrWhiteSpace(PriceCostTextBox.Text) || String.IsNullOrWhiteSpace(InventoryTextBox.Text) || String.IsNullOrWhiteSpace(MinTextBox.Text) || String.IsNullOrWhiteSpace(MaxTextBox.Text))
                {
                    MessageBox.Show("Fields cannot be empty");
                    return;
                }
                // verify integer fields are of the appropriate type
                if (int.Parse(IDTextBox.Text).GetType() != typeof(int) || int.Parse(InventoryTextBox.Text).GetType() != typeof(int) || int.Parse(MaxTextBox.Text).GetType() != typeof(int) || int.Parse(MaxTextBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("Ensure fields that require integers contain integers");
                    return;
                }
                // verify decimal field is of the appropriate type
                if (decimal.Parse(PriceCostTextBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show("Ensure Price field entry is in decimal format. Example: 0.00");
                    return;
                }
                // verify inventory level does not exceed max
                if (int.Parse(InventoryTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                // verify that minimum level does not exceed max
                if (int.Parse(MinTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                else
                {
                    try
                    {
                        Inhouse inhousePart = new Inhouse(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), int.Parse(IdentifierLabelTextBox.Text));
                        Inventory.UpdatePart(int.Parse(IDTextBox.Text), inhousePart);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong");
                        throw;
                    }
                    this.Close();
                }
            }  
            else
            {
                OutsourcedRadio.Checked = true;

                // verify fields are not null
                if (String.IsNullOrWhiteSpace(IDTextBox.Text) || String.IsNullOrWhiteSpace(NameTextBox.Text) || String.IsNullOrWhiteSpace(PriceCostTextBox.Text) || String.IsNullOrWhiteSpace(InventoryTextBox.Text) || String.IsNullOrWhiteSpace(MinTextBox.Text) || String.IsNullOrWhiteSpace(MaxTextBox.Text))
                {
                    MessageBox.Show("Fields cannot be empty");
                    return;
                }
                // verify integer fields are of the appropriate type
                if (int.Parse(IDTextBox.Text).GetType() != typeof(int) || int.Parse(InventoryTextBox.Text).GetType() != typeof(int) || int.Parse(MaxTextBox.Text).GetType() != typeof(int) || int.Parse(MaxTextBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("Ensure fields that require integers contain integers");
                    return;
                }
                // verify decimal field is of the appropriate type
                if (decimal.Parse(PriceCostTextBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show("Ensure Price field entry is in decimal format. Example: 0.00");
                    return;
                }
                // verify inventory level does not exceed max
                if (int.Parse(InventoryTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                // verify that minimum level does not exceed max
                if (int.Parse(MinTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                else
                {
                    // exception handling
                    try
                    {
                        Outsourced outsourcedPart = new Outsourced(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), IdentifierLabelTextBox.Text);
                        Inventory.UpdatePart(int.Parse(IDTextBox.Text), outsourcedPart);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong");
                        throw;
                    }
                    this.Close();
                }
            }
        }

        private void InhouseChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Machine ID";
        }

        private void OutsourcedChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Company Name";
        }
    }
}
