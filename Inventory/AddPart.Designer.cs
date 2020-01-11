using System.ComponentModel;

namespace Inventory
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            // this.components = new System.ComponentModel.Container();
            // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // this.ClientSize = new System.Drawing.Size(800, 450);
            // this.Text = "AddPartForm";
            
            
            this.InhouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceCost = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.IdentifierLabel = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.PriceCostTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.IdentifierLabelTextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InhouseRadio
            // 
            this.InhouseRadio.AutoSize = true;
            this.InhouseRadio.Location = new System.Drawing.Point(162, 29);
            this.InhouseRadio.Name = "InhouseRadio";
            this.InhouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InhouseRadio.TabIndex = 1;
            this.InhouseRadio.TabStop = true;
            this.InhouseRadio.Text = "In-House";
            this.InhouseRadio.UseVisualStyleBackColor = true;
            this.InhouseRadio.CheckedChanged += new System.EventHandler(this.InhouseChecked);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(251, 29);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 2;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourceChecked);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(176, 95);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(159, 130);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(143, 164);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 5;
            this.InventoryLabel.Text = "Inventory";
            // 
            // PriceCost
            // 
            this.PriceCost.AutoSize = true;
            this.PriceCost.Location = new System.Drawing.Point(131, 198);
            this.PriceCost.Name = "PriceCost";
            this.PriceCost.Size = new System.Drawing.Size(63, 13);
            this.PriceCost.TabIndex = 6;
            this.PriceCost.Text = "Price / Cost";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(337, 239);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(27, 13);
            this.Max.TabIndex = 7;
            this.Max.Text = "Max";
            // 
            // IdentifierLabel
            // 
            this.IdentifierLabel.AutoSize = true;
            this.IdentifierLabel.Location = new System.Drawing.Point(113, 282);
            this.IdentifierLabel.Name = "IdentifierLabel";
            this.IdentifierLabel.Size = new System.Drawing.Size(62, 13);
            this.IdentifierLabel.TabIndex = 8;
            this.IdentifierLabel.Text = "Machine ID";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(170, 239);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(24, 13);
            this.Min.TabIndex = 9;
            this.Min.Text = "Min";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(200, 92);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 10;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(200, 127);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 11;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(200, 161);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.InventoryTextBox.TabIndex = 12;
            // 
            // PriceCostTextBox
            // 
            this.PriceCostTextBox.Location = new System.Drawing.Point(200, 195);
            this.PriceCostTextBox.Name = "PriceCostTextBox";
            this.PriceCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceCostTextBox.TabIndex = 13;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(370, 236);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxTextBox.TabIndex = 14;
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(370, 236);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinTextBox.TabIndex = 15;
            // 
            // IdentifierLabelTextBox
            // 
            this.IdentifierLabelTextBox.Location = new System.Drawing.Point(200, 279);
            this.IdentifierLabelTextBox.Name = "IdentifierLabelTextBox";
            this.IdentifierLabelTextBox.Size = new System.Drawing.Size(151, 20);
            this.IdentifierLabelTextBox.TabIndex = 16;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(332, 361);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(432, 361);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLabel.Location = new System.Drawing.Point(39, 13);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(88, 25);
            this.AddPartLabel.TabIndex = 19;
            this.AddPartLabel.Text = "Add Part";
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption; 
            this.ClientSize = new System.Drawing.Size(548, 424);
            this.Controls.Add(this.AddPartLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.IdentifierLabelTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.PriceCostTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.IdentifierLabel);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.PriceCost);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InhouseRadio);
            this.Name = "AddPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        
        private System.Windows.Forms.RadioButton InhouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PriceCost;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label IdentifierLabel;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox PriceCostTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox IdentifierLabelTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label AddPartLabel;
    }
}