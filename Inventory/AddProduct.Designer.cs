using System.ComponentModel;

namespace Inventory
{
    partial class AddProduct
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
            this.Add_Product_Label = new System.Windows.Forms.Label();
            this.AddProduct_CandidateParts_GridView = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddProduct_Search_TextBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Candidate_Parts_Label = new System.Windows.Forms.Label();
            this.Parts_Associated_Label = new System.Windows.Forms.Label();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.AddProduct_PartsAssociated_GridView = new System.Windows.Forms.DataGridView();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResetFields_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.AddProduct_CandidateParts_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.AddProduct_PartsAssociated_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Product_Label
            // 
            this.Add_Product_Label.AutoSize = true;
            this.Add_Product_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Add_Product_Label.Location = new System.Drawing.Point(48, 32);
            this.Add_Product_Label.Name = "Add_Product_Label";
            this.Add_Product_Label.Size = new System.Drawing.Size(120, 25);
            this.Add_Product_Label.TabIndex = 18;
            this.Add_Product_Label.Text = "Add Product";
            // 
            // AddProduct_CandidateParts_GridView
            // 
            this.AddProduct_CandidateParts_GridView.AllowUserToResizeColumns = false;
            this.AddProduct_CandidateParts_GridView.AllowUserToResizeRows = false;
            this.AddProduct_CandidateParts_GridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProduct_CandidateParts_GridView.EditMode =
                System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AddProduct_CandidateParts_GridView.Location = new System.Drawing.Point(484, 90);
            this.AddProduct_CandidateParts_GridView.Name = "AddProduct_CandidateParts_GridView";
            this.AddProduct_CandidateParts_GridView.RowHeadersWidthSizeMode =
                System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AddProduct_CandidateParts_GridView.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddProduct_CandidateParts_GridView.Size = new System.Drawing.Size(471, 148);
            this.AddProduct_CandidateParts_GridView.TabIndex = 22;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(868, 245);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(87, 27);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(593, 32);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(87, 27);
            this.SearchBtn.TabIndex = 19;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddProduct_Search_TextBox
            // 
            this.AddProduct_Search_TextBox.Location = new System.Drawing.Point(687, 36);
            this.AddProduct_Search_TextBox.Name = "AddProduct_Search_TextBox";
            this.AddProduct_Search_TextBox.Size = new System.Drawing.Size(268, 23);
            this.AddProduct_Search_TextBox.TabIndex = 17;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(868, 455);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(87, 27);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Candidate_Parts_Label
            // 
            this.Candidate_Parts_Label.AutoSize = true;
            this.Candidate_Parts_Label.Location = new System.Drawing.Point(484, 68);
            this.Candidate_Parts_Label.Name = "Candidate_Parts_Label";
            this.Candidate_Parts_Label.Size = new System.Drawing.Size(107, 15);
            this.Candidate_Parts_Label.TabIndex = 24;
            this.Candidate_Parts_Label.Text = "All Candidate Parts";
            // 
            // Parts_Associated_Label
            // 
            this.Parts_Associated_Label.AutoSize = true;
            this.Parts_Associated_Label.Location = new System.Drawing.Point(484, 278);
            this.Parts_Associated_Label.Name = "Parts_Associated_Label";
            this.Parts_Associated_Label.Size = new System.Drawing.Size(186, 15);
            this.Parts_Associated_Label.TabIndex = 25;
            this.Parts_Associated_Label.Text = "Parts Associated with this Product";
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(141, 312);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(116, 23);
            this.MinTextBox.TabIndex = 36;
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(347, 312);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(131, 23);
            this.MaxTextBox.TabIndex = 37;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(141, 271);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(116, 23);
            this.PriceTextBox.TabIndex = 35;
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(141, 230);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(116, 23);
            this.InventoryTextBox.TabIndex = 34;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(141, 187);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(116, 23);
            this.NameTextBox.TabIndex = 33;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(141, 142);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(116, 23);
            this.IDTextBox.TabIndex = 32;
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(77, 320);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(28, 15);
            this.Min.TabIndex = 31;
            this.Min.Text = "Min";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(299, 320);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(30, 15);
            this.Max.TabIndex = 30;
            this.Max.Text = "Max";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(73, 275);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(33, 15);
            this.Price.TabIndex = 29;
            this.Price.Text = "Price";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(71, 233);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(57, 15);
            this.InventoryLabel.TabIndex = 28;
            this.InventoryLabel.Text = "Inventory";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(71, 190);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 27;
            this.NameLabel.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(71, 150);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 15);
            this.ID.TabIndex = 26;
            this.ID.Text = "ID";
            // 
            // AddProduct_PartsAssociated_GridView
            // 
            this.AddProduct_PartsAssociated_GridView.AllowUserToResizeColumns = false;
            this.AddProduct_PartsAssociated_GridView.AllowUserToResizeRows = false;
            this.AddProduct_PartsAssociated_GridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProduct_PartsAssociated_GridView.EditMode =
                System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AddProduct_PartsAssociated_GridView.Location = new System.Drawing.Point(484, 300);
            this.AddProduct_PartsAssociated_GridView.Name = "AddProduct_PartsAssociated_GridView";
            this.AddProduct_PartsAssociated_GridView.RowHeadersWidthSizeMode =
                System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AddProduct_PartsAssociated_GridView.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddProduct_PartsAssociated_GridView.Size = new System.Drawing.Size(471, 148);
            this.AddProduct_PartsAssociated_GridView.TabIndex = 38;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(868, 488);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(87, 27);
            this.CancelBtn.TabIndex = 39;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(758, 488);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(87, 27);
            this.SaveBtn.TabIndex = 40;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ResetFields_Btn
            // 
            this.ResetFields_Btn.Location = new System.Drawing.Point(159, 474);
            this.ResetFields_Btn.Name = "ResetFields_Btn";
            this.ResetFields_Btn.Size = new System.Drawing.Size(75, 23);
            this.ResetFields_Btn.TabIndex = 41;
            this.ResetFields_Btn.Text = "Reset Fields";
            this.ResetFields_Btn.UseVisualStyleBackColor = true;
            this.ResetFields_Btn.Click += new System.EventHandler(this.ResetFields_Btn_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 524);
            this.Controls.Add(this.ResetFields_Btn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddProduct_PartsAssociated_GridView);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Parts_Associated_Label);
            this.Controls.Add(this.Candidate_Parts_Label);
            this.Controls.Add(this.AddProduct_CandidateParts_GridView);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Add_Product_Label);
            this.Controls.Add(this.AddProduct_Search_TextBox);
            this.Controls.Add(this.DeleteBtn);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize) (this.AddProduct_CandidateParts_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.AddProduct_PartsAssociated_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView AddProduct_CandidateParts_GridView;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox AddProduct_Search_TextBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label Candidate_Parts_Label;
        private System.Windows.Forms.Label Parts_Associated_Label;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.DataGridView AddProduct_PartsAssociated_GridView;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ResetFields_Btn;
        private System.Windows.Forms.Label Add_Product_Label;
    }
}