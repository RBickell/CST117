namespace MilestoneProjectCST117__InventoryList
{
    partial class Form1
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
            this.InventorytitleLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddToStockLabel = new System.Windows.Forms.Label();
            this.DeleteFromStockLabel = new System.Windows.Forms.Label();
            this.TotalInStockLabel = new System.Windows.Forms.Label();
            this.GetListButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.DeleteInvButton = new System.Windows.Forms.Button();
            this.EditInvButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ProductIDNumbox = new System.Windows.Forms.NumericUpDown();
            this.ProductNameTextbox = new System.Windows.Forms.TextBox();
            this.CategoryTextbox = new System.Windows.Forms.TextBox();
            this.PriceNumbox = new System.Windows.Forms.NumericUpDown();
            this.AddStockNumbox = new System.Windows.Forms.NumericUpDown();
            this.DeleteStockNumbox = new System.Windows.Forms.NumericUpDown();
            this.TotalStockNumbox = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDNumbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStockNumbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteStockNumbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalStockNumbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InventorytitleLabel
            // 
            this.InventorytitleLabel.AutoSize = true;
            this.InventorytitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventorytitleLabel.Location = new System.Drawing.Point(368, 9);
            this.InventorytitleLabel.Name = "InventorytitleLabel";
            this.InventorytitleLabel.Size = new System.Drawing.Size(219, 37);
            this.InventorytitleLabel.TabIndex = 0;
            this.InventorytitleLabel.Text = "Inventory List";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(29, 134);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(100, 20);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(29, 170);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(127, 20);
            this.ProductNameLabel.TabIndex = 2;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryLabel.Location = new System.Drawing.Point(29, 212);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(153, 20);
            this.ProductCategoryLabel.TabIndex = 3;
            this.ProductCategoryLabel.Text = "Product Category:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(491, 134);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(54, 20);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price:";
            // 
            // AddToStockLabel
            // 
            this.AddToStockLabel.AutoSize = true;
            this.AddToStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToStockLabel.Location = new System.Drawing.Point(427, 170);
            this.AddToStockLabel.Name = "AddToStockLabel";
            this.AddToStockLabel.Size = new System.Drawing.Size(118, 20);
            this.AddToStockLabel.TabIndex = 5;
            this.AddToStockLabel.Text = "Add to Stock:";
            // 
            // DeleteFromStockLabel
            // 
            this.DeleteFromStockLabel.AutoSize = true;
            this.DeleteFromStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFromStockLabel.Location = new System.Drawing.Point(386, 212);
            this.DeleteFromStockLabel.Name = "DeleteFromStockLabel";
            this.DeleteFromStockLabel.Size = new System.Drawing.Size(159, 20);
            this.DeleteFromStockLabel.TabIndex = 6;
            this.DeleteFromStockLabel.Text = "Delete from Stock:";
            // 
            // TotalInStockLabel
            // 
            this.TotalInStockLabel.AutoSize = true;
            this.TotalInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInStockLabel.Location = new System.Drawing.Point(741, 134);
            this.TotalInStockLabel.Name = "TotalInStockLabel";
            this.TotalInStockLabel.Size = new System.Drawing.Size(126, 20);
            this.TotalInStockLabel.TabIndex = 7;
            this.TotalInStockLabel.Text = "Total In Stock:";
            // 
            // GetListButton
            // 
            this.GetListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GetListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetListButton.ForeColor = System.Drawing.Color.White;
            this.GetListButton.Location = new System.Drawing.Point(33, 61);
            this.GetListButton.Name = "GetListButton";
            this.GetListButton.Size = new System.Drawing.Size(93, 48);
            this.GetListButton.TabIndex = 9;
            this.GetListButton.Text = "Get List";
            this.GetListButton.UseVisualStyleBackColor = false;
            // 
            // AddNewButton
            // 
            this.AddNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.ForeColor = System.Drawing.Color.White;
            this.AddNewButton.Location = new System.Drawing.Point(161, 61);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(103, 48);
            this.AddNewButton.TabIndex = 10;
            this.AddNewButton.Text = "Add New Inventory";
            this.AddNewButton.UseVisualStyleBackColor = false;
            // 
            // DeleteInvButton
            // 
            this.DeleteInvButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeleteInvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInvButton.ForeColor = System.Drawing.Color.White;
            this.DeleteInvButton.Location = new System.Drawing.Point(296, 61);
            this.DeleteInvButton.Name = "DeleteInvButton";
            this.DeleteInvButton.Size = new System.Drawing.Size(103, 48);
            this.DeleteInvButton.TabIndex = 11;
            this.DeleteInvButton.Text = "Delete Inventory";
            this.DeleteInvButton.UseVisualStyleBackColor = false;
            // 
            // EditInvButton
            // 
            this.EditInvButton.BackColor = System.Drawing.Color.Teal;
            this.EditInvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInvButton.ForeColor = System.Drawing.Color.White;
            this.EditInvButton.Location = new System.Drawing.Point(433, 60);
            this.EditInvButton.Name = "EditInvButton";
            this.EditInvButton.Size = new System.Drawing.Size(112, 48);
            this.EditInvButton.TabIndex = 12;
            this.EditInvButton.Text = "Edit Inventory Stock";
            this.EditInvButton.UseVisualStyleBackColor = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(609, 61);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 48);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Inventory Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(765, 61);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 48);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit Program";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // ProductIDNumbox
            // 
            this.ProductIDNumbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDNumbox.Location = new System.Drawing.Point(188, 132);
            this.ProductIDNumbox.Name = "ProductIDNumbox";
            this.ProductIDNumbox.Size = new System.Drawing.Size(120, 26);
            this.ProductIDNumbox.TabIndex = 15;
            // 
            // ProductNameTextbox
            // 
            this.ProductNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTextbox.Location = new System.Drawing.Point(188, 167);
            this.ProductNameTextbox.Name = "ProductNameTextbox";
            this.ProductNameTextbox.Size = new System.Drawing.Size(159, 26);
            this.ProductNameTextbox.TabIndex = 16;
            // 
            // CategoryTextbox
            // 
            this.CategoryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextbox.Location = new System.Drawing.Point(188, 206);
            this.CategoryTextbox.Name = "CategoryTextbox";
            this.CategoryTextbox.Size = new System.Drawing.Size(159, 26);
            this.CategoryTextbox.TabIndex = 17;
            // 
            // PriceNumbox
            // 
            this.PriceNumbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceNumbox.Location = new System.Drawing.Point(568, 132);
            this.PriceNumbox.Name = "PriceNumbox";
            this.PriceNumbox.Size = new System.Drawing.Size(120, 26);
            this.PriceNumbox.TabIndex = 18;
            // 
            // AddStockNumbox
            // 
            this.AddStockNumbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockNumbox.Location = new System.Drawing.Point(568, 170);
            this.AddStockNumbox.Name = "AddStockNumbox";
            this.AddStockNumbox.Size = new System.Drawing.Size(120, 26);
            this.AddStockNumbox.TabIndex = 19;
            // 
            // DeleteStockNumbox
            // 
            this.DeleteStockNumbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStockNumbox.Location = new System.Drawing.Point(568, 207);
            this.DeleteStockNumbox.Name = "DeleteStockNumbox";
            this.DeleteStockNumbox.Size = new System.Drawing.Size(120, 26);
            this.DeleteStockNumbox.TabIndex = 20;
            // 
            // TotalStockNumbox
            // 
            this.TotalStockNumbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStockNumbox.Location = new System.Drawing.Point(745, 170);
            this.TotalStockNumbox.Name = "TotalStockNumbox";
            this.TotalStockNumbox.Size = new System.Drawing.Size(120, 26);
            this.TotalStockNumbox.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductCategory,
            this.ProductPrice,
            this.TotalInStock,
            this.CostinStock});
            this.dataGridView1.Location = new System.Drawing.Point(148, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 275);
            this.dataGridView1.TabIndex = 22;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // ProductCategory
            // 
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.Name = "ProductCategory";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // TotalInStock
            // 
            this.TotalInStock.HeaderText = "Total in Stock";
            this.TotalInStock.Name = "TotalInStock";
            // 
            // CostinStock
            // 
            this.CostinStock.HeaderText = "Cost in Stock";
            this.CostinStock.Name = "CostinStock";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TotalStockNumbox);
            this.Controls.Add(this.DeleteStockNumbox);
            this.Controls.Add(this.AddStockNumbox);
            this.Controls.Add(this.PriceNumbox);
            this.Controls.Add(this.CategoryTextbox);
            this.Controls.Add(this.ProductNameTextbox);
            this.Controls.Add(this.ProductIDNumbox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EditInvButton);
            this.Controls.Add(this.DeleteInvButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.GetListButton);
            this.Controls.Add(this.TotalInStockLabel);
            this.Controls.Add(this.DeleteFromStockLabel);
            this.Controls.Add(this.AddToStockLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductCategoryLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.InventorytitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductIDNumbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStockNumbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteStockNumbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalStockNumbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InventorytitleLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label AddToStockLabel;
        private System.Windows.Forms.Label DeleteFromStockLabel;
        private System.Windows.Forms.Label TotalInStockLabel;
        private System.Windows.Forms.Button GetListButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button DeleteInvButton;
        private System.Windows.Forms.Button EditInvButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.NumericUpDown ProductIDNumbox;
        private System.Windows.Forms.TextBox ProductNameTextbox;
        private System.Windows.Forms.TextBox CategoryTextbox;
        private System.Windows.Forms.NumericUpDown PriceNumbox;
        private System.Windows.Forms.NumericUpDown AddStockNumbox;
        private System.Windows.Forms.NumericUpDown DeleteStockNumbox;
        private System.Windows.Forms.NumericUpDown TotalStockNumbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostinStock;
    }
}

