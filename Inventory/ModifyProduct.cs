using System;
using System.Globalization;
using System.Windows.Forms;
using static System.Int32;
using static System.String;

namespace Inventory
{
    public partial class ModifyProduct : Form
    {
        public ModifyProduct(Product product)
        {
            InitializeComponent();

            IDTextBox.Text = Convert.ToString(product.ProductID);
            NameTextBox.Text = product.Name;
            InventoryTextBox.Text = Convert.ToString(product.InStock);
            PriceTextBox.Text = Convert.ToString(product.Price, CultureInfo.InvariantCulture);
            MinTextBox.Text = Convert.ToString(product.Min);
            MaxTextBox.Text = Convert.ToString(product.Max);

            ModifyProduct_CandidateParts_GridView.DataSource = Inventory.Parts;
            ModifyProduct_PartsAssociated_GridView.DataSource = product.AssociatedParts;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (IsNullOrWhiteSpace(IDTextBox.Text) || IsNullOrWhiteSpace(NameTextBox.Text) ||
                IsNullOrWhiteSpace(PriceTextBox.Text) || IsNullOrWhiteSpace(InventoryTextBox.Text) ||
                IsNullOrWhiteSpace(MinTextBox.Text) || IsNullOrWhiteSpace(MaxTextBox.Text))
            {
                MessageBox.Show(@"Fields must not be empty");
                return;
            }
            if (Parse(IDTextBox.Text).GetType() != typeof(int) ||
                Parse(InventoryTextBox.Text).GetType() != typeof(int) ||
                Parse(MaxTextBox.Text).GetType() != typeof(int) ||
                Parse(MaxTextBox.Text).GetType() != typeof(int))
            {
                MessageBox.Show(@"Field must be integer");
                return;
            }
            if (decimal.Parse(PriceTextBox.Text).GetType() != typeof(decimal))
            {
                MessageBox.Show(@"Must be a decimal");
                return;
            }
            if (Parse(InventoryTextBox.Text) > Parse(MaxTextBox.Text))
            {
                MessageBox.Show(@"Over maximum allowed stock level.");
                return;
            }
            if (Parse(MinTextBox.Text) > Parse(MaxTextBox.Text))
            {
                MessageBox.Show(@"Set minimum stock level less than max stock level");
            }
            else
            {
                try
                {
                    Product product = new Product(Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceTextBox.Text), Parse(InventoryTextBox.Text), Parse(MinTextBox.Text), Parse(MaxTextBox.Text));
                    try
                    {
                        foreach (DataGridViewRow row in ModifyProduct_PartsAssociated_GridView.Rows)
                        {
                            Part associatedPart = (Part)row.DataBoundItem;
                            product.AssociatedParts.Add(associatedPart);
                        }
                    }
                    catch
                    {
                        // ignored
                    }

                    Inventory.UpdateProduct(Parse(IDTextBox.Text), product);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Unknown Error");
                    throw;
                }
                this.Close();
            }
        }
    
        private void ModifyProduct_Search_Btn_Click(object sender, EventArgs e)
        {
            if (ModifyProduct_Search_TextBox.TextLength <= 0) return;
            try
            {
                foreach (DataGridViewRow row in ModifyProduct_CandidateParts_GridView.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    Part userEntry = Inventory.LookupPart(Convert.ToInt32(ModifyProduct_Search_TextBox.Text));

                    if (userEntry.PartID == part.PartID)
                    {
                        row.Selected = true;
                        ModifyProduct_CandidateParts_GridView.CurrentCell = row.Cells[0];
                        return;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
            catch { }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(@"Are you sure you want to delete?", @"Delete", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = ModifyProduct_PartsAssociated_GridView.CurrentCell.RowIndex;
                    ModifyProduct_PartsAssociated_GridView.Rows.RemoveAt(rowIndex);
                }
                else return;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(IDTextBox.Text);
            int partId = Convert.ToInt32(ModifyProduct_CandidateParts_GridView.Rows[ModifyProduct_CandidateParts_GridView.CurrentCell.RowIndex].Cells[0].Value);
            Product product = Inventory.LookupProduct(productId);
            Part part = Inventory.LookupPart(partId);
            Inventory.UpdateProduct(productId, product);
            product.AddAssociatedPart(part);
            ModifyProduct_PartsAssociated_GridView.DataSource = product.AssociatedParts;
        }

        private void Form1Load(object sender, EventArgs e)
        {
            ///throw new NotImplementedException();
        }
    }
}
