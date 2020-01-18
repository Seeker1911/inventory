namespace Inventory
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            // this.components = new System.ComponentModel.Container();
            // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // this.ClientSize = new System.Drawing.Size(800, 450);
            // this.Text = "Main_Form";
            
            System.Windows.Forms.Label InventoryManagementSystem;
            System.Windows.Forms.Label Parts;
            System.Windows.Forms.Label Products;
            this.Main_Parts_Add_Btn = new System.Windows.Forms.Button();
            this.Main_Parts_Modify_Btn = new System.Windows.Forms.Button();
            this.Main_Parts_Delete_Btn = new System.Windows.Forms.Button();
            this.Main_Parts_Search_TextBox = new System.Windows.Forms.TextBox();
            this.Main_Parts_Search_Btn = new System.Windows.Forms.Button();
            this.Main_Products_Add_Btn = new System.Windows.Forms.Button();
            this.Main_Products_Modify_Btn = new System.Windows.Forms.Button();
            this.Main_Products_Delete_Btn = new System.Windows.Forms.Button();
            this.Main_Exit_Btn = new System.Windows.Forms.Button();
            this.Main_Products_Search_Btn = new System.Windows.Forms.Button();
            this.Main_Products_Search_TextBox = new System.Windows.Forms.TextBox();
            this.MainParts_GridView = new System.Windows.Forms.DataGridView();
            this.MainProducts_GridView = new System.Windows.Forms.DataGridView();
            InventoryManagementSystem = new System.Windows.Forms.Label();
            Parts = new System.Windows.Forms.Label();
            Products = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainParts_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainProducts_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryManagementSystem
            // 
            InventoryManagementSystem.AutoSize = true;
            InventoryManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            InventoryManagementSystem.Location = new System.Drawing.Point(29, 13);
            InventoryManagementSystem.Name = "InventoryManagementSystem";
            InventoryManagementSystem.Size = new System.Drawing.Size(283, 25);
            InventoryManagementSystem.TabIndex = 4;
            InventoryManagementSystem.Text = "Inventory Management System";
            // 
            // Parts
            // 
            Parts.AutoSize = true;
            Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Parts.Location = new System.Drawing.Point(30, 85);
            Parts.Name = "Parts";
            Parts.Size = new System.Drawing.Size(46, 20);
            Parts.TabIndex = 12;
            Parts.Text = "Parts";
            // 
            // Products
            // 
            Products.AutoSize = true;
            Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Products.Location = new System.Drawing.Point(520, 85);
            Products.Name = "Products";
            Products.Size = new System.Drawing.Size(72, 20);
            Products.TabIndex = 13;
            Products.Text = "Products";
            // 
            // Main_Parts_Add_Btn
            // 
            this.Main_Parts_Add_Btn.Location = new System.Drawing.Point(245, 322);
            this.Main_Parts_Add_Btn.Name = "Main_Parts_Add_Btn";
            this.Main_Parts_Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Parts_Add_Btn.TabIndex = 0;
            this.Main_Parts_Add_Btn.Text = "Add";
            this.Main_Parts_Add_Btn.UseVisualStyleBackColor = true;
            this.Main_Parts_Add_Btn.Click += new System.EventHandler(this.Main_Parts_Add_Btn_Click);
            // 
            // Main_Parts_Modify_Btn
            // 
            this.Main_Parts_Modify_Btn.Location = new System.Drawing.Point(326, 322);
            this.Main_Parts_Modify_Btn.Name = "Main_Parts_Modify_Btn";
            this.Main_Parts_Modify_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Parts_Modify_Btn.TabIndex = 1;
            this.Main_Parts_Modify_Btn.Text = "Modify";
            this.Main_Parts_Modify_Btn.UseVisualStyleBackColor = true;
            this.Main_Parts_Modify_Btn.Click += new System.EventHandler(this.Main_Parts_Modify_Btn_Click);
            // 
            // Main_Parts_Delete_Btn
            // 
            this.Main_Parts_Delete_Btn.Location = new System.Drawing.Point(407, 322);
            this.Main_Parts_Delete_Btn.Name = "Main_Parts_Delete_Btn";
            this.Main_Parts_Delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Parts_Delete_Btn.TabIndex = 2;
            this.Main_Parts_Delete_Btn.Text = "Delete";
            this.Main_Parts_Delete_Btn.UseVisualStyleBackColor = true;
            this.Main_Parts_Delete_Btn.Click += new System.EventHandler(this.Main_Parts_Delete_Btn_Click);
            // 
            // Main_Parts_Search_TextBox
            // 
            this.Main_Parts_Search_TextBox.Location = new System.Drawing.Point(344, 73);
            this.Main_Parts_Search_TextBox.Name = "Main_Parts_Search_TextBox";
            this.Main_Parts_Search_TextBox.Size = new System.Drawing.Size(139, 20);
            this.Main_Parts_Search_TextBox.TabIndex = 3;
            this.Main_Parts_Search_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_Parts_Search_TextBox_KeyPress);
            // 
            // Main_Parts_Search_Btn
            // 
            this.Main_Parts_Search_Btn.Location = new System.Drawing.Point(263, 70);
            this.Main_Parts_Search_Btn.Name = "Main_Parts_Search_Btn";
            this.Main_Parts_Search_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Parts_Search_Btn.TabIndex = 5;
            this.Main_Parts_Search_Btn.Text = "Search";
            this.Main_Parts_Search_Btn.UseVisualStyleBackColor = true;
            this.Main_Parts_Search_Btn.Click += new System.EventHandler(this.Main_Parts_Search_Btn_Click);
            // 
            // Main_Products_Add_Btn
            // 
            this.Main_Products_Add_Btn.Location = new System.Drawing.Point(737, 322);
            this.Main_Products_Add_Btn.Name = "Main_Products_Add_Btn";
            this.Main_Products_Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Products_Add_Btn.TabIndex = 6;
            this.Main_Products_Add_Btn.Text = "Add";
            this.Main_Products_Add_Btn.UseVisualStyleBackColor = true;
            this.Main_Products_Add_Btn.Click += new System.EventHandler(this.Main_Products_Add_Btn_Click);
            // 
            // Main_Products_Modify_Btn
            // 
            this.Main_Products_Modify_Btn.Location = new System.Drawing.Point(818, 322);
            this.Main_Products_Modify_Btn.Name = "Main_Products_Modify_Btn";
            this.Main_Products_Modify_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Products_Modify_Btn.TabIndex = 7;
            this.Main_Products_Modify_Btn.Text = "Modify";
            this.Main_Products_Modify_Btn.UseVisualStyleBackColor = true;
            this.Main_Products_Modify_Btn.Click += new System.EventHandler(this.Main_Products_Modify_Btn_Click);
            // 
            // Main_Products_Delete_Btn
            // 
            this.Main_Products_Delete_Btn.Location = new System.Drawing.Point(899, 321);
            this.Main_Products_Delete_Btn.Name = "Main_Products_Delete_Btn";
            this.Main_Products_Delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Products_Delete_Btn.TabIndex = 8;
            this.Main_Products_Delete_Btn.Text = "Delete";
            this.Main_Products_Delete_Btn.UseVisualStyleBackColor = true;
            this.Main_Products_Delete_Btn.Click += new System.EventHandler(this.Main_Products_Delete_Btn_Click);
            // 
            // Main_Exit_Btn
            // 
            this.Main_Exit_Btn.Location = new System.Drawing.Point(839, 366);
            this.Main_Exit_Btn.Name = "Main_Exit_Btn";
            this.Main_Exit_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Exit_Btn.TabIndex = 9;
            this.Main_Exit_Btn.Text = "Exit";
            this.Main_Exit_Btn.UseVisualStyleBackColor = true;
            this.Main_Exit_Btn.Click += new System.EventHandler(this.Main_Exit_Btn_Click);
            // 
            // Main_Products_Search_Btn
            // 
            this.Main_Products_Search_Btn.Location = new System.Drawing.Point(757, 73);
            this.Main_Products_Search_Btn.Name = "Main_Products_Search_Btn";
            this.Main_Products_Search_Btn.Size = new System.Drawing.Size(75, 23);
            this.Main_Products_Search_Btn.TabIndex = 10;
            this.Main_Products_Search_Btn.Text = "Search";
            this.Main_Products_Search_Btn.UseVisualStyleBackColor = true;
            this.Main_Products_Search_Btn.Click += new System.EventHandler(this.Main_Products_Search_Btn_Click);
            // 
            // Main_Products_Search_TextBox
            // 
            this.Main_Products_Search_TextBox.Location = new System.Drawing.Point(838, 76);
            this.Main_Products_Search_TextBox.Name = "Main_Products_Search_TextBox";
            this.Main_Products_Search_TextBox.Size = new System.Drawing.Size(136, 20);
            this.Main_Products_Search_TextBox.TabIndex = 11;
            this.Main_Products_Search_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_Products_Search_TextBox_KeyPress);
            // 
            // MainParts_GridView
            // 
            this.MainParts_GridView.AllowUserToOrderColumns = true;
            this.MainParts_GridView.AllowUserToResizeColumns = false;
            this.MainParts_GridView.AllowUserToResizeRows = false;
            this.MainParts_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainParts_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainParts_GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainParts_GridView.Location = new System.Drawing.Point(34, 109);
            this.MainParts_GridView.Name = "MainParts_GridView";
            this.MainParts_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainParts_GridView.Size = new System.Drawing.Size(448, 207);
            this.MainParts_GridView.TabIndex = 14;
            // 
            // MainProducts_GridView
            // 
            this.MainProducts_GridView.AllowUserToResizeColumns = false;
            this.MainProducts_GridView.AllowUserToResizeRows = false;
            this.MainProducts_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainProducts_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainProducts_GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainProducts_GridView.Location = new System.Drawing.Point(524, 109);
            this.MainProducts_GridView.MultiSelect = false;
            this.MainProducts_GridView.Name = "MainProducts_GridView";
            this.MainProducts_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainProducts_GridView.ShowCellErrors = false;
            this.MainProducts_GridView.Size = new System.Drawing.Size(448, 207);
            this.MainProducts_GridView.TabIndex = 15;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 408);
            this.Controls.Add(this.MainProducts_GridView);
            this.Controls.Add(this.MainParts_GridView);
            this.Controls.Add(Products);
            this.Controls.Add(Parts);
            this.Controls.Add(this.Main_Products_Search_TextBox);
            this.Controls.Add(this.Main_Products_Search_Btn);
            this.Controls.Add(this.Main_Exit_Btn);
            this.Controls.Add(this.Main_Products_Delete_Btn);
            this.Controls.Add(this.Main_Products_Modify_Btn);
            this.Controls.Add(this.Main_Products_Add_Btn);
            this.Controls.Add(this.Main_Parts_Search_Btn);
            this.Controls.Add(InventoryManagementSystem);
            this.Controls.Add(this.Main_Parts_Search_TextBox);
            this.Controls.Add(this.Main_Parts_Delete_Btn);
            this.Controls.Add(this.Main_Parts_Modify_Btn);
            this.Controls.Add(this.Main_Parts_Add_Btn);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainParts_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainProducts_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        
        private System.Windows.Forms.Button Main_Parts_Add_Btn;
        private System.Windows.Forms.Button Main_Parts_Modify_Btn;
        private System.Windows.Forms.Button Main_Parts_Delete_Btn;
        private System.Windows.Forms.TextBox Main_Parts_Search_TextBox;
        private System.Windows.Forms.Button Main_Parts_Search_Btn;
        private System.Windows.Forms.Button Main_Products_Add_Btn;
        private System.Windows.Forms.Button Main_Products_Modify_Btn;
        private System.Windows.Forms.Button Main_Products_Delete_Btn;
        private System.Windows.Forms.Button Main_Exit_Btn;
        private System.Windows.Forms.Button Main_Products_Search_Btn;
        private System.Windows.Forms.TextBox Main_Products_Search_TextBox;
        public System.Windows.Forms.DataGridView MainProducts_GridView;
        public System.Windows.Forms.DataGridView MainParts_GridView;
    }
}