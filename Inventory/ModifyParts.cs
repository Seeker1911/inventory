using System;
using System.Globalization;
using System.Windows.Forms;
using static System.Int32;
using static System.String;

namespace Inventory
{

    public partial class ModifyParts: Form
    {
        public static ModifyParts CreateInstance(Inhouse inhouse)
        {
            return new ModifyParts(inhouse);
        }

        public ModifyParts()
        {
            InitializeComponent();
        }

        private ModifyParts(Inhouse inhouse)
        {
            InitializeComponent();
            
            IDTextBox.Text = Convert.ToString(inhouse.PartID);
            NameTextBox.Text = inhouse.Name;
            InventoryTextBox.Text = Convert.ToString(inhouse.InStock);
            PriceCostTextBox.Text = Convert.ToString(inhouse.Price, CultureInfo.InvariantCulture);
            MinTextBox.Text = Convert.ToString(inhouse.Min);
            MaxTextBox.Text = Convert.ToString(inhouse.Max);
            IdentifierLabelTextBox.Text = Convert.ToString(inhouse.MachineID);
            IdentifierLabel.Text = @"Machine ID";
            InhouseRadio.Checked = true;
        }

        public ModifyParts(Outsourced outsourced)
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

                if (IsNullOrWhiteSpace(IDTextBox.Text) || IsNullOrWhiteSpace(NameTextBox.Text) ||
                    IsNullOrWhiteSpace(PriceCostTextBox.Text) || IsNullOrWhiteSpace(InventoryTextBox.Text) ||
                    IsNullOrWhiteSpace(MinTextBox.Text) || IsNullOrWhiteSpace(MaxTextBox.Text))
                {
                    MessageBox.Show(@"Fields cannot be empty");
                    return;
                }
                // verify integer fields are of the appropriate type
                if (Parse(IDTextBox.Text).GetType() != typeof(int) || Parse(InventoryTextBox.Text).GetType() != typeof(int) || Parse(MaxTextBox.Text).GetType() != typeof(int) || Parse(MaxTextBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show(@"Must contain integer");
                    return;
                }
                // verify decimal field is of the appropriate type
                if (decimal.Parse(PriceCostTextBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show(@"Must be decimal");
                    return;
                }
                // verify inventory level does not exceed max
                if (Parse(InventoryTextBox.Text) > Parse(MaxTextBox.Text))
                {
                    MessageBox.Show(@"Can not exceed maximum stock level.");
                    return;
                }
                // verify that minimum level does not exceed max
                if (Parse(MinTextBox.Text) > Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                else
                {
                    try
                    {
                        Inhouse inhousePart = new Inhouse(Parse(IDTextBox.Text), NameTextBox.Text,
                            decimal.Parse(PriceCostTextBox.Text), Parse(InventoryTextBox.Text),
                            Parse(MinTextBox.Text), Parse(MaxTextBox.Text),
                       Parse(IdentifierLabelTextBox.Text));
                        Inventory.UpdatePart(Parse(IDTextBox.Text), inhousePart);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(@"Unknown Error");
                        throw;
                    }
                    Close();
                }
            }  
            else
            {
                OutsourcedRadio.Checked = true;

                if (IsNullOrWhiteSpace(IDTextBox.Text) || IsNullOrWhiteSpace(NameTextBox.Text) ||
                    IsNullOrWhiteSpace(PriceCostTextBox.Text) || IsNullOrWhiteSpace(InventoryTextBox.Text) ||
                    IsNullOrWhiteSpace(MinTextBox.Text) || IsNullOrWhiteSpace(MaxTextBox.Text))
                {
                    MessageBox.Show(@"Fields cannot be empty");
                    return;
                }
                if (Parse(IDTextBox.Text).GetType() != typeof(int) ||
                    Parse(InventoryTextBox.Text).GetType() != typeof(int) ||
                    Parse(MaxTextBox.Text).GetType() != typeof(int) || Parse(MaxTextBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show(@"Must contain integers");
                    return;
                }
                if (decimal.Parse(PriceCostTextBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show(@"Must be a decimal");
                    return;
                }
                if (Parse(InventoryTextBox.Text) > Parse(MaxTextBox.Text))
                {
                    MessageBox.Show(@"Stock level can not exceed Maximum");
                    return;
                }
                if (Parse(MinTextBox.Text) > Parse(MaxTextBox.Text))
                {
                    MessageBox.Show(@"Minimum stock can not exceed maximum");
                }
                else
                {
                    try
                    {
                        Outsourced outsourcedPart = new Outsourced(Parse(IDTextBox.Text), NameTextBox.Text,
                            decimal.Parse(PriceCostTextBox.Text), Parse(InventoryTextBox.Text), Parse(MinTextBox.Text),
                            Parse(MaxTextBox.Text), IdentifierLabelTextBox.Text);
                        Inventory.UpdatePart(Parse(IDTextBox.Text), outsourcedPart);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(@"Error");
                        throw;
                    }
                    Close();
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
