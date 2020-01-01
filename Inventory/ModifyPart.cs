using System;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ModifyPart : Form
    {
        Main_Form mainScreen = new Main_Form();
        public ModifyPart()
        {
            InitializeComponent();
        }
        public ModifyPart(Inhouse inhouse)
        {
            InitializeComponent();
            
            IDTextBox.Text = Convert.ToString(inhouse.PartID);
            NameTextBox.Text = inhouse.Name;
            InventoryTextBox.Text = Convert.ToString(inhouse.InStock);
            PriceCostTextBox.Text = Convert.ToString(inhouse.Price);
            MinTextBox.Text = Convert.ToString(inhouse.Min);
            MaxTextBox.Text = Convert.ToString(inhouse.Max);
            IdentifierLabelTextBox.Text = Convert.ToString(inhouse.MachineID);
            IdentifierLabel.Text = "Machine ID";
            InhouseRadio.Checked = true;
        }

        public ModifyPart(Outsourced outsourced)
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
                Inhouse inhousePart = new Inhouse(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), int.Parse(IdentifierLabelTextBox.Text));
                Inventory.UpdatePart(int.Parse(IDTextBox.Text), inhousePart);
                mainScreen.MainParts_GridView.Update();
                mainScreen.MainParts_GridView.Refresh();
            }  
            else
            {
                OutsourcedRadio.Checked = true;
                Outsourced outsourcedPart = new Outsourced(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), IdentifierLabelTextBox.Text);
                Inventory.UpdatePart(int.Parse(IDTextBox.Text), outsourcedPart);
                mainScreen.MainParts_GridView.Update();
                mainScreen.MainParts_GridView.Refresh();
            }
            Close();
            mainScreen.MainParts_GridView.Update();
            mainScreen.MainParts_GridView.Refresh();
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