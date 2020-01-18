using System;
using System.Windows.Forms;
using static System.String;

namespace Inventory
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            InhouseCheck.Checked = true;
        }
        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void InhouseChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Machine ID";
        }

        private void OutsourceChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Company Name";
        }

        private void SaveButton(object sender, EventArgs e)
        {
            if (InhouseCheck.Checked)
            {

                InhouseCheck.Checked = true;
                if (MaxTextBox != null)
                {
                    if (IDTextBox != null)
                    {
                        Inhouse inhousePart = new Inhouse(int.Parse(IDTextBox.Text), NameTextBox.Text,
                            decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text),
                            int.Parse(MaxTextBox.Text), int.Parse(IdentifierLabelTextBox.Text));
                        if (IsNullOrWhiteSpace(NameTextBox.Text))
                        {
                            throw new ArgumentNullException(@"Name cannot be empty");
                        }
                        if (int.Parse(IDTextBox.Text) != inhousePart.PartID)
                        {
                            MessageBox.Show(@"Cannot alter Product's ID");
                            return;

                        }
                        if (int.Parse(MinTextBox.Text) > int.Parse(MaxTextBox.Text))
                        {
                            MessageBox.Show(@"Minimum permitted stock level cannot exceed Maximum permitted stock level");
                            return;
                        }
                        if (int.Parse(InventoryTextBox.Text) > int.Parse(MaxTextBox.Text))
                        {
                            MessageBox.Show(@"Inventory stock level cannot exceed Maximum permitted stock level");
                            return;
                        }

                        Inventory.AddPart(inhousePart);
                    }
                }
            }
            else
            {
                OutsourcedCheck.Checked = true;
                Outsourced outsourcedPart = new Outsourced(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text),int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), IdentifierLabelTextBox.Text);
                if (IsNullOrWhiteSpace(NameTextBox.Text))
                {
                    throw new ArgumentNullException(@"Name cannot be empty");
                }
                if (int.Parse(IDTextBox.Text) != outsourcedPart.PartID)
                {
                    MessageBox.Show(@"Cannot alter Product's ID");
                    return;

                }
                if (int.Parse(InventoryTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show(@"Inventory stock level cannot be greater than max.");
                    return;
                }
                if (int.Parse(MinTextBox.Text) > int.Parse(MaxTextBox.Text))
                {
                    MessageBox.Show(@"Minimum stock level cannot exceed Maximum stock level");
                    return;
                }
                else
                {
                    Inventory.AddPart(outsourcedPart);
                }

            }
            Close();
        }
    }
}