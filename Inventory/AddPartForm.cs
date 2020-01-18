using System;
using System.Windows.Forms;

namespace Inventory
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            InhouseRadio.Checked = true;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InhouseChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Machine ID";
        }

        private void OutsourceChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Company Name";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (InhouseRadio.Checked)
            {

                InhouseRadio.Checked = true;
                // Inhouse inhousePart = new Inhouse(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), int.Parse(IdentifierLabelTextBox.Text));
                // Inventory.AddPart(inhousePart);
                Inhouse inhousePart = new Inhouse(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text),int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), int.Parse(IdentifierLabelTextBox.Text));
                if (String.IsNullOrWhiteSpace(NameTextBox.Text))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                if (int.Parse(IDTextBox.Text) != inhousePart.PartID)
                {
                    MessageBox.Show("Cannot alter Product's ID");
                    return;

                }
                if (int.Parse(InventoryTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                if (int.Parse(MinTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                else
                {
                    Inventory.AddPart(inhousePart);
                }
            }
            else
            {
                OutsourcedRadio.Checked = true;
                // Outsourced outsourcedPart = new Outsourced(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), IdentifierLabelTextBox.Text);
                // Inventory.AddPart(outsourcedPart);
                Outsourced outsourcedPart = new Outsourced(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text),int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), IdentifierLabelTextBox.Text);
                if (String.IsNullOrWhiteSpace(NameTextBox.Text))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                if (int.Parse(IDTextBox.Text) != outsourcedPart.PartID)
                {
                    MessageBox.Show("Cannot alter Product's ID");
                    return;

                }
                if (int.Parse(InventoryTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                if (int.Parse(MinTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level");
                    return;
                }
                else
                {
                    Inventory.AddPart(outsourcedPart);
                }

            }
            // Inventory.RefreshLists();
            Close();
        }
    }
}