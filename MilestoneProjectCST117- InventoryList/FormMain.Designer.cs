namespace MilestoneProjectCST117__InventoryList
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InventorytitleLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.DeleteInvButton = new System.Windows.Forms.Button();
            this.EditInvButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TBProductName = new System.Windows.Forms.TextBox();
            this.TBCategory = new System.Windows.Forms.TextBox();
            this.DGVInput = new System.Windows.Forms.DataGridView();
            this.ColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBProductID = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SSLbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventorytitleLabel
            // 
            this.InventorytitleLabel.AutoSize = true;
            this.InventorytitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventorytitleLabel.Location = new System.Drawing.Point(356, 80);
            this.InventorytitleLabel.Name = "InventorytitleLabel";
            this.InventorytitleLabel.Size = new System.Drawing.Size(219, 37);
            this.InventorytitleLabel.TabIndex = 10;
            this.InventorytitleLabel.Text = "Inventory List";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(294, 131);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(127, 20);
            this.ProductNameLabel.TabIndex = 13;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryLabel.Location = new System.Drawing.Point(487, 131);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(153, 20);
            this.ProductCategoryLabel.TabIndex = 15;
            this.ProductCategoryLabel.Text = "Product Category:";
            // 
            // AddNewButton
            // 
            this.AddNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.ForeColor = System.Drawing.Color.White;
            this.AddNewButton.Location = new System.Drawing.Point(115, 12);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(147, 43);
            this.AddNewButton.TabIndex = 1;
            this.AddNewButton.Text = "Add New Inventory";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // DeleteInvButton
            // 
            this.DeleteInvButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeleteInvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInvButton.ForeColor = System.Drawing.Color.White;
            this.DeleteInvButton.Location = new System.Drawing.Point(296, 12);
            this.DeleteInvButton.Name = "DeleteInvButton";
            this.DeleteInvButton.Size = new System.Drawing.Size(150, 43);
            this.DeleteInvButton.TabIndex = 2;
            this.DeleteInvButton.Text = "Delete Inventory";
            this.DeleteInvButton.UseVisualStyleBackColor = false;
            this.DeleteInvButton.Click += new System.EventHandler(this.DeleteInvButton_Click);
            // 
            // EditInvButton
            // 
            this.EditInvButton.BackColor = System.Drawing.Color.Teal;
            this.EditInvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInvButton.ForeColor = System.Drawing.Color.White;
            this.EditInvButton.Location = new System.Drawing.Point(480, 12);
            this.EditInvButton.Name = "EditInvButton";
            this.EditInvButton.Size = new System.Drawing.Size(171, 43);
            this.EditInvButton.TabIndex = 3;
            this.EditInvButton.Text = "Edit Inventory Stock";
            this.EditInvButton.UseVisualStyleBackColor = false;
            this.EditInvButton.Click += new System.EventHandler(this.EditInvButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(660, 131);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(96, 50);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Inventory Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(685, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(166, 43);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit Program";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TBProductName
            // 
            this.TBProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProductName.Location = new System.Drawing.Point(298, 154);
            this.TBProductName.Name = "TBProductName";
            this.TBProductName.Size = new System.Drawing.Size(159, 26);
            this.TBProductName.TabIndex = 5;
            this.TBProductName.TextChanged += new System.EventHandler(this.TBProductName_TextChanged);
            // 
            // TBCategory
            // 
            this.TBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCategory.Location = new System.Drawing.Point(491, 154);
            this.TBCategory.Name = "TBCategory";
            this.TBCategory.Size = new System.Drawing.Size(159, 26);
            this.TBCategory.TabIndex = 6;
            this.TBCategory.TextChanged += new System.EventHandler(this.TBCategory_TextChanged);
            // 
            // DGVInput
            // 
            this.DGVInput.AllowUserToAddRows = false;
            this.DGVInput.AllowUserToDeleteRows = false;
            this.DGVInput.AllowUserToResizeColumns = false;
            this.DGVInput.AllowUserToResizeRows = false;
            this.DGVInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductID,
            this.ColProductName,
            this.ColProductCategory,
            this.ColPrice,
            this.ColTotalInStock,
            this.colCostInStock});
            this.DGVInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVInput.Location = new System.Drawing.Point(0, 208);
            this.DGVInput.Name = "DGVInput";
            this.DGVInput.RowHeadersVisible = false;
            this.DGVInput.RowHeadersWidth = 28;
            this.DGVInput.Size = new System.Drawing.Size(914, 317);
            this.DGVInput.TabIndex = 9;
            this.DGVInput.DataSourceChanged += new System.EventHandler(this.DGVInput_DataSourceChanged);
            // 
            // ColProductID
            // 
            this.ColProductID.DataPropertyName = "ID";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.ColProductID.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColProductID.HeaderText = "ID";
            this.ColProductID.Name = "ColProductID";
            this.ColProductID.Width = 40;
            // 
            // ColProductName
            // 
            this.ColProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColProductName.DataPropertyName = "ProductName";
            this.ColProductName.HeaderText = "Product Name";
            this.ColProductName.Name = "ColProductName";
            // 
            // ColProductCategory
            // 
            this.ColProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColProductCategory.DataPropertyName = "Category";
            this.ColProductCategory.HeaderText = "Category";
            this.ColProductCategory.Name = "ColProductCategory";
            // 
            // ColPrice
            // 
            this.ColPrice.DataPropertyName = "Price";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.ColPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.Width = 65;
            // 
            // ColTotalInStock
            // 
            this.ColTotalInStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColTotalInStock.DataPropertyName = "AddInStock";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.ColTotalInStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColTotalInStock.HeaderText = "Total In Stock";
            this.ColTotalInStock.Name = "ColTotalInStock";
            this.ColTotalInStock.Width = 99;
            // 
            // colCostInStock
            // 
            this.colCostInStock.DataPropertyName = "CostInStock";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.colCostInStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCostInStock.HeaderText = "Cost In Stock";
            this.colCostInStock.Name = "colCostInStock";
            this.colCostInStock.Width = 120;
            // 
            // LblProductID
            // 
            this.LblProductID.AutoSize = true;
            this.LblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductID.Location = new System.Drawing.Point(338, 130);
            this.LblProductID.Name = "LblProductID";
            this.LblProductID.Size = new System.Drawing.Size(0, 20);
            this.LblProductID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 12;
            // 
            // TBProductID
            // 
            this.TBProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProductID.Location = new System.Drawing.Point(144, 154);
            this.TBProductID.Name = "TBProductID";
            this.TBProductID.Size = new System.Drawing.Size(118, 26);
            this.TBProductID.TabIndex = 4;
            this.TBProductID.TextChanged += new System.EventHandler(this.TBProductID_TextChanged);
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLbl.Location = new System.Drawing.Point(140, 131);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(100, 20);
            this.ProductIDLbl.TabIndex = 11;
            this.ProductIDLbl.Text = "Product ID:";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(776, 131);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(93, 49);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 186);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SSLbl
            // 
            this.SSLbl.Name = "SSLbl";
            this.SSLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 525);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBProductID);
            this.Controls.Add(this.ProductIDLbl);
            this.Controls.Add(this.LblProductID);
            this.Controls.Add(this.DGVInput);
            this.Controls.Add(this.TBCategory);
            this.Controls.Add(this.TBProductName);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EditInvButton);
            this.Controls.Add(this.DeleteInvButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.ProductCategoryLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.InventorytitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory List";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InventorytitleLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button DeleteInvButton;
        private System.Windows.Forms.Button EditInvButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox TBProductName;
        private System.Windows.Forms.TextBox TBCategory;
        private System.Windows.Forms.DataGridView DGVInput;
        private System.Windows.Forms.Label LblProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBProductID;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SSLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostInStock;
    }
}

