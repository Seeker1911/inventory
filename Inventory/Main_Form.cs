using System;
using System.Windows.Forms;

namespace Inventory
{
    public partial class MainForm : Form
    {
        Product Product = new Product();
        public MainForm()
        {
            InitializeComponent();
            CreateProducts();
            RefreshForm();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void CreateProducts()
        {
            // Create products
            Inventory.Products.Add(new Product(001, "Python book", 20.99m, 20, 1, 100));
            Inventory.Products.Add(new Product(002, "Golang book", 23.00m, 80, 1, 100));
            Inventory.Products.Add(new Product(003, "Javascript book", 10.00m, 50, 1, 100));
            Inventory.Products.Add(new Product(004, "C sharp book", 100.00m, 30, 1, 100));

            // Create inhouse parts
            Inventory.Parts.Add(new Inhouse(001, "binder", 5.00m, 150, 1, 1000, 1111));
            Inventory.Parts.Add(new Inhouse(002, "cover", 8.00m, 25, 1, 1000, 1112));
            Inventory.Parts.Add(new Inhouse(003, "packaging", 5.00m, 89, 1, 1000, 1113));

            // Create outsourced parts
            Inventory.Parts.Add(new Outsourced(004, "paper", 30.00m, 10, 1, 50, "Dunder Miflin"));
            Inventory.Parts.Add(new Outsourced(005, "ink", 20.00m, 20, 1, 50, "Hemingway ink co."));
            Inventory.Parts.Add(new Outsourced(006, "Straps", 36.99m, 115, 1, 10, "no good ideas"));

            // Pre-add associated parts
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(001));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(002));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(003));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(004));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(005));
            
            
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(001));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(002));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(003));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(004));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(005));
            
            
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(001));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(002));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(003));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(004));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(005));
            
            
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(001));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(002));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(003));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(004));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(005));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(006));
        }
        public void RefreshForm()
        {
            MainParts_GridView.DataSource = Inventory.Parts;
            MainParts_GridView.ClearSelection();

            MainProducts_GridView.DataSource = Inventory.Products;
            MainProducts_GridView.ClearSelection();
        }

        private void Main_Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Parts_Search_Btn_Click(object sender, EventArgs e)
        {
            if (Main_Parts_Search_TextBox.TextLength > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in MainParts_GridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(Main_Parts_Search_TextBox.Text));

                        if (userEntry.PartID == part?.PartID)
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
                catch { }
            }
        }

        private void Main_Parts_Search_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Main_Parts_Search_TextBox.TextLength > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in MainParts_GridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(Main_Parts_Search_TextBox.Text));

                        if (userEntry.PartID == part?.PartID)
                        {
                            row.Selected = true;
                            MainParts_GridView.CurrentCell = row.Cells[0];
                            return;
                        }

                        row.Selected = false;
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        private void Main_Parts_Add_Btn_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.Show();
        }

        private void Main_Parts_Modify_Btn_Click(object sender, EventArgs e)
        {
            if (MainParts_GridView.CurrentRow != null && MainParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse inhousePart = (Inhouse)MainParts_GridView.CurrentRow.DataBoundItem;
                new ModifyPart(inhousePart).ShowDialog();
                RefreshForm();
            }
            else if (MainParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                Outsourced outsourcedPart = (Outsourced)MainParts_GridView.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedPart).ShowDialog();
                RefreshForm();
            }

        }

        private void Main_Parts_Delete_Btn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(@"Are you sure you want to delete this ?", @"Delete", MessageBoxButtons.OKCancel);
            {

                if (confirm == DialogResult.OK)
                {
                    var rowIndex = MainParts_GridView.CurrentCell.RowIndex;
                    MainParts_GridView.Rows.RemoveAt(rowIndex);
                    Product.RemoveAssociatedPart(rowIndex);
                }
                // else return;
            }
        }

        private void Main_Products_Search_Btn_Click(object sender, EventArgs e)
        {
            if (Main_Products_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in MainProducts_GridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        Product userEntry = Inventory.LookupProduct(Convert.ToInt32(Main_Products_Search_TextBox.Text));

                        if (userEntry.ProductID == product?.ProductID)
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
                catch
                {
                }
            }
        }

        private void Main_Products_Search_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Main_Products_Search_TextBox.TextLength > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in MainProducts_GridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        Product userEntry = Inventory.LookupProduct(Convert.ToInt32(Main_Products_Search_TextBox.Text));

                        if (userEntry.ProductID == product?.ProductID)
                        {
                            row.Selected = true;
                            MainProducts_GridView.CurrentCell = row.Cells[0];
                            return;
                        }

                        row.Selected = false;
                    }
                }
                catch { }
            }
        }

        private void Main_Products_Add_Btn_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }

        private void Main_Products_Modify_Btn_Click(object sender, EventArgs e)
        {
            if (MainProducts_GridView.CurrentRow != null)
            {
                Product product = (Product)MainProducts_GridView.CurrentRow.DataBoundItem;
                new ModifyProduct(product).ShowDialog();
            }
            RefreshForm();
        }

        private void Main_Products_Delete_Btn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(@"Are you sure you want to delete this ?", @"Delete", MessageBoxButtons.OKCancel);
            if (confirm != DialogResult.OK)
                return;
            if (MainProducts_GridView.CurrentRow == null) return;
            Product product = (Product) MainProducts_GridView.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show(@"Cannot delete a product that has associated parts.");
            }
            else
            {
                var rowIndex = MainProducts_GridView.CurrentCell.RowIndex;
                MainProducts_GridView.Rows.RemoveAt(rowIndex);
            }
        }
    }
}
