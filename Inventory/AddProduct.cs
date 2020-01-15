using System;
using System.Windows.Forms;

namespace Inventory
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Add_Product_Form_Load(object sender, EventArgs e)
        {
            // AddProduct_CandidateParts_GridView.DataSource = Inventory.Parts;
            //AddProduct_PartsAssociated_GridView.DataSource = Product.AssociatedParts;

            // bind base list of parts to DataGridView using a DataSource intermediary
            var bsPart = new BindingSource();
            bsPart.DataSource = Inventory.Parts;
            AddProduct_CandidateParts_GridView.DataSource = bsPart;

            bsPart.DataSource = null;
            bsPart.DataSource = Inventory.Parts;


            // bind base list of AssociatedParts to DataGridView using a DataSource intermediary
            var bsProduct = new BindingSource();
            var product = new Product();
            bsProduct.DataSource = Product.AssociatedParts;
            AddProduct_PartsAssociated_GridView.DataSource = bsProduct;

            bsProduct.DataSource = null;
            bsProduct.DataSource = Product.AssociatedParts;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceTextBox.Text),
                int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text));
            Inventory.AddProduct(product);
            // Inventory.RefreshLists();
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (AddProduct_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {

                foreach (DataGridViewRow row in AddProduct_CandidateParts_GridView.Rows)
                {
                    Part part = (Part) row.DataBoundItem;
                    Part userEntry = Inventory.LookupPart(Convert.ToInt32(AddProduct_Search_TextBox.Text));

                    if (userEntry.PartID == part.PartID)
                    {
                        row.Selected = true;
                        AddProduct_CandidateParts_GridView.CurrentCell = row.Cells[0];
                        return;
                    }
                    else
                    {
                        row.Selected = false;
                    }

                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AddProduct_CandidateParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse inhousePart = (Inhouse) AddProduct_CandidateParts_GridView.CurrentRow.DataBoundItem;
                Product product = new Product();
                product.AddAssociatedPart(inhousePart);


            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Please confirm that you wish to remove this item", "Delete?",
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
    }
}