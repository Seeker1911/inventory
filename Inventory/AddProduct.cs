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
            AddProduct_CandidateParts_GridView.DataSource = Inventory.Parts;
 
            AddProduct_PartsAssociated_GridView.DataSource = Product.AssociatedParts;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text));
            Inventory.AddProduct(product);
            Inventory.RefreshLists();
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
                    Part part = (Part)row.DataBoundItem;
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
                Inhouse inhousePart = (Inhouse)AddProduct_CandidateParts_GridView.CurrentRow.DataBoundItem;
                Product product = new Product();
                product.AddAssociatedPart(inhousePart);


            }
         
        }
    }
}