//using System.ComponentModel;

namespace Inventory
{
    partial class ModifyParts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private IContainer components = null;
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.IdentifierLabelTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.PriceCostTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.Label();
            this.IdentifierLabel = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.PriceCost = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.InhouseRadio = new System.Windows.Forms.RadioButton();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ModifyPartLabel.Location = new System.Drawing.Point(47, 10);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(110, 25);
            this.ModifyPartLabel.TabIndex = 36;
            this.ModifyPartLabel.Text = "Modify Part";
            // 
            // IdentifierLabelTextBox
            // 
            this.IdentifierLabelTextBox.Location = new System.Drawing.Point(241, 320);
            this.IdentifierLabelTextBox.Name = "IdentifierLabelTextBox";
            this.IdentifierLabelTextBox.Size = new System.Drawing.Size(175, 23);
            this.IdentifierLabelTextBox.TabIndex = 52;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(439, 270);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(131, 23);
            this.MaxTextBox.TabIndex = 51;
            // this.MaxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(239, 270);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(116, 23);
            this.MinTextBox.TabIndex = 50;
            // 
            // PriceCostTextBox
            // 
            this.PriceCostTextBox.Location = new System.Drawing.Point(241, 223);
            this.PriceCostTextBox.Name = "PriceCostTextBox";
            this.PriceCostTextBox.Size = new System.Drawing.Size(116, 23);
            this.PriceCostTextBox.TabIndex = 49;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(241, 183);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(116, 23);
            this.InventoryTextBox.TabIndex = 48;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(241, 144);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(116, 23);
            this.NameTextBox.TabIndex = 47;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(241, 104);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(116, 23);
            this.IDTextBox.TabIndex = 46;
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(405, 273);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(30, 15);
            this.Max.TabIndex = 45;
            this.Max.Text = "Max";
            //this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // IdentifierLabel
            // 
            this.IdentifierLabel.AutoSize = true;
            this.IdentifierLabel.Location = new System.Drawing.Point(140, 323);
            this.IdentifierLabel.Name = "IdentifierLabel";
            this.IdentifierLabel.Size = new System.Drawing.Size(67, 15);
            this.IdentifierLabel.TabIndex = 44;
            this.IdentifierLabel.Text = "Machine ID";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(203, 273);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(28, 15);
            this.Min.TabIndex = 43;
            this.Min.Text = "Min";
            // 
            // PriceCost
            // 
            this.PriceCost.AutoSize = true;
            this.PriceCost.Location = new System.Drawing.Point(161, 226);
            this.PriceCost.Name = "PriceCost";
            this.PriceCost.Size = new System.Drawing.Size(68, 15);
            this.PriceCost.TabIndex = 42;
            this.PriceCost.Text = "Price / Cost";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(175, 187);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(57, 15);
            this.InventoryLabel.TabIndex = 41;
            this.InventoryLabel.Text = "Inventory";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(194, 148);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 40;
            this.NameLabel.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(213, 107);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 15);
            this.ID.TabIndex = 39;
            this.ID.Text = "ID";
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(301, 31);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(87, 19);
            this.OutsourcedRadio.TabIndex = 38;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedChecked);
            // 
            // InhouseRadio
            // 
            this.InhouseRadio.AutoSize = true;
            this.InhouseRadio.Location = new System.Drawing.Point(197, 31);
            this.InhouseRadio.Name = "InhouseRadio";
            this.InhouseRadio.Size = new System.Drawing.Size(74, 19);
            this.InhouseRadio.TabIndex = 37;
            this.InhouseRadio.TabStop = true;
            this.InhouseRadio.Text = "In-House";
            this.InhouseRadio.UseVisualStyleBackColor = true;
            this.InhouseRadio.CheckedChanged += new System.EventHandler(this.InhouseChecked);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(510, 434);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(87, 27);
            this.CancelBtn.TabIndex = 54;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(393, 434);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(87, 27);
            this.SaveBtn.TabIndex = 53;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ModifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 492);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.IdentifierLabelTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.PriceCostTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.IdentifierLabel);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.PriceCost);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InhouseRadio);
            this.Controls.Add(this.ModifyPartLabel);
            this.Name = "ModifyParts";
            this.Text = "Inventory Part";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label ModifyPartLabel;
        private System.Windows.Forms.TextBox IdentifierLabelTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox PriceCostTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label IdentifierLabel;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label PriceCost;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.RadioButton InhouseRadio;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}