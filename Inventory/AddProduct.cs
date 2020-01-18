using System;
using System.Windows.Forms;
using static System.Int32;
using static System.String;

namespace Inventory
{
    public partial class AddProduct : Form
    {
        Product product = new Product();
        public AddProduct()
        {
            InitializeComponent();
            AddProduct_CandidateParts_GridView.DataSource = Inventory.Parts;
            AddProduct_PartsAssociated_GridView.DataSource = product.AssociatedParts;
        }

        private void Add_Product_Form_Load(object sender, EventArgs e)
        {
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton(object sender, EventArgs e)
        {
            if (IsNullOrWhiteSpace(IDTextBox.Text) || IsNullOrWhiteSpace(NameTextBox.Text) ||
                IsNullOrWhiteSpace(PriceTextBox.Text) || IsNullOrWhiteSpace(InventoryTextBox.Text) ||
                IsNullOrWhiteSpace(MinTextBox.Text) || IsNullOrWhiteSpace(MaxTextBox.Text))
            {
                MessageBox.Show(@"Must not be empty");
                return;
            }
            if (Parse(IDTextBox.Text).GetType() != typeof(int) ||
                Parse(InventoryTextBox.Text).GetType() != typeof(int) ||
                Parse(MaxTextBox.Text).GetType() != typeof(int) ||
                Parse(MaxTextBox.Text).GetType() != typeof(int))
            {
                MessageBox.Show(@"Must contain integer");
                return;
            }
            if (decimal.Parse(PriceTextBox.Text).GetType() != typeof(decimal))
            {
                MessageBox.Show(@"Must be decimal");
                return;
            }
            if (Parse(InventoryTextBox.Text) > Parse(MaxTextBox.Text))
            {
                MessageBox.Show(@"Inventory can not exceed maximum stock level");
                return;
            }
            if (Parse(MinTextBox.Text) > Parse(MaxTextBox.Text))
            {
                MessageBox.Show(@"Minimum stock can not exceed max stock allowed.");
            }
            else
            {
                try
                {
                    Product product = new Product(Parse(IDTextBox.Text), NameTextBox.Text,
                        decimal.Parse(PriceTextBox.Text), Parse(InventoryTextBox.Text), Parse(MinTextBox.Text),
                        Parse(MaxTextBox.Text));
                    try
                    {
                        foreach (DataGridViewRow row in AddProduct_PartsAssociated_GridView.Rows)
                        {
                            Part associatedPart = (Part)row.DataBoundItem;
                            product.AssociatedParts.Add(associatedPart);
                        }
                    }
                    catch { }
                    Inventory.AddProduct(product);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Error");
                    throw;
                }
                Close();
            }
        }

        private void SearchButton(object sender, EventArgs e)
        {
            if (AddProduct_Search_TextBox == null || AddProduct_Search_TextBox.TextLength >= 0)
            {
                try
                {
                    foreach (DataGridViewRow row in AddProduct_CandidateParts_GridView.Rows)
                    {
                        Part part = (Part) row.DataBoundItem;
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(AddProduct_Search_TextBox.Text));

                        if (userEntry.PartID == part?.PartID
                        )
                        {
                            row.Selected = true;
                            AddProduct_CandidateParts_GridView.CurrentCell = row.Cells[0];
                            return;
                        }
                        row.Selected = false;
                    }
                }
                catch
                {
                }
            }
        }

        private void AddButton(object sender, EventArgs e)
        {
            Part part = (Part)AddProduct_CandidateParts_GridView.CurrentRow.DataBoundItem;
            product.AddAssociatedPart(part);
        }

        private void DeleteButton(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(@"Are you sure you want to delete?", @"Delete",
                MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = AddProduct_PartsAssociated_GridView.CurrentCell.RowIndex;
                    AddProduct_PartsAssociated_GridView.Rows.RemoveAt(rowIndex);
                }
                else return;
            }
        }
        private void ResetAllFields(object sender, EventArgs e)
        {
            foreach (Control cont in Controls)
            {
                if (cont is TextBox box)
                {
                    box.Text = Empty;
                }
            }
        }
    }
}