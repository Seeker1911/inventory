using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Inhouse inhousePart = new Inhouse(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), int.Parse(IdentifierLabelTextBox.Text));
                Inventory.AddPart(inhousePart);

            }
            else
            {
                OutsourcedRadio.Checked = true;
                Outsourced outsourcedPart = new Outsourced(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), IdentifierLabelTextBox.Text);
                Inventory.AddPart(outsourcedPart);

            }
            Inventory.RefreshLists();
            Close();
        }
    }
}