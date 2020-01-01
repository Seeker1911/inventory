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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize base lists of parts and products

            Inventory.InitializeProductsAndParts();

            // bind base list of parts to DataGridView using a DataSource intermediary
            var bsPart = new BindingSource();
            bsPart.DataSource = Inventory.Parts;
            MainParts_GridView.DataSource = bsPart;


            // bind base list of products to DataGridView using a DataSource intermediary
            var bsProduct = new BindingSource();
            bsProduct.DataSource = Inventory.Products;
            MainProducts_GridView.DataSource = bsProduct;

            /*
            bsPart.DataSource = null;
            bsPart.DataSource = Inventory.Parts;

            bsProduct.DataSource = null;
            bsProduct.DataSource = Inventory.Products;
            */

        }

        private void Main_Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ---------------Part methods------------------//

        private void Main_Parts_Search_Btn_Click(object sender, EventArgs e)
        {
            if (Main_Parts_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {
               
                foreach (DataGridViewRow row in MainParts_GridView.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    Part userEntry = Inventory.LookupPart(Convert.ToInt32(Main_Parts_Search_TextBox.Text));

                    if (userEntry.PartID == part.PartID)
                    {
                        row.Selected = true;
                        MainParts_GridView.CurrentCell = row.Cells[0];
                        return;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                    
                }
            }
        }

        private void Main_Parts_Add_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Add part screen
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.Show();
        }

        private void Main_Parts_Modify_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Modfy part screen with instance of user type selected by row
            if (MainParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse inhousePart = (Inhouse)MainParts_GridView.CurrentRow.DataBoundItem;
                new ModifyPart(inhousePart).ShowDialog();
            }
            else if (MainParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                Outsourced outsourcedPart = (Outsourced)MainParts_GridView.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedPart).ShowDialog();
                
            } 
  
        }

        private void Main_Parts_Delete_Btn_Click(object sender, EventArgs e)
        {
            var rowIndex = MainParts_GridView.CurrentCell.RowIndex;
            MainParts_GridView.Rows.RemoveAt(rowIndex);
        }

        // ---------------Product methods------------------//
        private void Main_Products_Search_Btn_Click(object sender, EventArgs e)
        {

            if (Main_Products_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {

                foreach (DataGridViewRow row in MainProducts_GridView.Rows)
                {
                    Product product = (Product)row.DataBoundItem;
                    Product userEntry = Inventory.LookupProduct(Convert.ToInt32(Main_Products_Search_TextBox.Text));

                    if (userEntry.ProductID == product.ProductID)
                    {
                        row.Selected = true;
                        MainProducts_GridView.CurrentCell = row.Cells[0];
                        return;
                    }
                    else
                    {
                        row.Selected = false;
                    }

                }
            }
        }

        private void Main_Products_Add_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Add product screen
            new AddProduct().ShowDialog();
        }

        private void Main_Products_Modify_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Modfy product screen
            Product product = (Product)MainProducts_GridView.CurrentRow.DataBoundItem;
            new ModifyProduct(product).ShowDialog();
        }

        private void Main_Products_Delete_Btn_Click(object sender, EventArgs e)
        {
            Product product = (Product)MainProducts_GridView.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete a product that has associated parts.  Remove assosicated parts prior to attempting to remove a product.");
            }
            else
            {
                var rowIndex = MainProducts_GridView.CurrentCell.RowIndex;
                MainProducts_GridView.Rows.RemoveAt(rowIndex);
            }
        }

    }
}
