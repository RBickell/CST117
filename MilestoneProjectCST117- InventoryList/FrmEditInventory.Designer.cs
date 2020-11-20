namespace MilestoneProjectCST117__InventoryList
{
    partial class FrmEditInventory
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
            this.LblEditInventory = new System.Windows.Forms.Label();
            this.NUDPrice = new System.Windows.Forms.NumericUpDown();
            this.TBCategory = new System.Windows.Forms.TextBox();
            this.TBProductName = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBProductID = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.BtnEditClose = new System.Windows.Forms.Button();
            this.LblINStock = new System.Windows.Forms.Label();
            this.LblCostinStock = new System.Windows.Forms.Label();
            this.NUDEditInStock = new System.Windows.Forms.NumericUpDown();
            this.NUDEditCostInStock = new System.Windows.Forms.NumericUpDown();
            this.DGVInputEditInventory = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEditInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEditCostInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputEditInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEditInventory
            // 
            this.LblEditInventory.AutoSize = true;
            this.LblEditInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditInventory.Location = new System.Drawing.Point(384, 21);
            this.LblEditInventory.Name = "LblEditInventory";
            this.LblEditInventory.Size = new System.Drawing.Size(224, 37);
            this.LblEditInventory.TabIndex = 15;
            this.LblEditInventory.Text = "Edit Inventory";
            // 
            // NUDPrice
            // 
            this.NUDPrice.DecimalPlaces = 2;
            this.NUDPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDPrice.Location = new System.Drawing.Point(110, 213);
            this.NUDPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUDPrice.Name = "NUDPrice";
            this.NUDPrice.Size = new System.Drawing.Size(120, 22);
            this.NUDPrice.TabIndex = 3;
            this.NUDPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDPrice.ValueChanged += new System.EventHandler(this.NUDPrice_ValueChanged);
            // 
            // TBCategory
            // 
            this.TBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCategory.Location = new System.Drawing.Point(110, 183);
            this.TBCategory.Name = "TBCategory";
            this.TBCategory.Size = new System.Drawing.Size(120, 22);
            this.TBCategory.TabIndex = 2;
            this.TBCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBCategory.TextChanged += new System.EventHandler(this.TBCategory_TextChanged);
            // 
            // TBProductName
            // 
            this.TBProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProductName.Location = new System.Drawing.Point(110, 152);
            this.TBProductName.Name = "TBProductName";
            this.TBProductName.Size = new System.Drawing.Size(120, 22);
            this.TBProductName.TabIndex = 1;
            this.TBProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBProductName.TextChanged += new System.EventHandler(this.TBProductName_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(56, 215);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(48, 16);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Price:";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryLabel.Location = new System.Drawing.Point(29, 186);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(75, 16);
            this.ProductCategoryLabel.TabIndex = 11;
            this.ProductCategoryLabel.Text = "Category:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(51, 155);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(53, 16);
            this.ProductNameLabel.TabIndex = 10;
            this.ProductNameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 16;
            // 
            // TBProductID
            // 
            this.TBProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProductID.Location = new System.Drawing.Point(110, 124);
            this.TBProductID.Name = "TBProductID";
            this.TBProductID.Size = new System.Drawing.Size(120, 22);
            this.TBProductID.TabIndex = 0;
            this.TBProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBProductID.TextChanged += new System.EventHandler(this.TBProductID_TextChanged);
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLbl.Location = new System.Drawing.Point(77, 127);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(27, 16);
            this.ProductIDLbl.TabIndex = 9;
            this.ProductIDLbl.Text = "ID:";
            // 
            // BtnEditClose
            // 
            this.BtnEditClose.BackColor = System.Drawing.Color.Black;
            this.BtnEditClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEditClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditClose.ForeColor = System.Drawing.Color.White;
            this.BtnEditClose.Location = new System.Drawing.Point(434, 429);
            this.BtnEditClose.Name = "BtnEditClose";
            this.BtnEditClose.Size = new System.Drawing.Size(161, 41);
            this.BtnEditClose.TabIndex = 8;
            this.BtnEditClose.Text = "Close Edit screen";
            this.BtnEditClose.UseVisualStyleBackColor = false;
            this.BtnEditClose.Click += new System.EventHandler(this.BtnEditClose_Click);
            // 
            // LblINStock
            // 
            this.LblINStock.AutoSize = true;
            this.LblINStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblINStock.Location = new System.Drawing.Point(37, 243);
            this.LblINStock.Name = "LblINStock";
            this.LblINStock.Size = new System.Drawing.Size(67, 16);
            this.LblINStock.TabIndex = 13;
            this.LblINStock.Text = "In Stock:";
            // 
            // LblCostinStock
            // 
            this.LblCostinStock.AutoSize = true;
            this.LblCostinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCostinStock.Location = new System.Drawing.Point(2, 274);
            this.LblCostinStock.Name = "LblCostinStock";
            this.LblCostinStock.Size = new System.Drawing.Size(102, 16);
            this.LblCostinStock.TabIndex = 14;
            this.LblCostinStock.Text = "Cost In Stock:";
            // 
            // NUDEditInStock
            // 
            this.NUDEditInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDEditInStock.Location = new System.Drawing.Point(110, 241);
            this.NUDEditInStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDEditInStock.Name = "NUDEditInStock";
            this.NUDEditInStock.Size = new System.Drawing.Size(120, 22);
            this.NUDEditInStock.TabIndex = 4;
            this.NUDEditInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDEditInStock.ValueChanged += new System.EventHandler(this.NUDEditInStock_ValueChanged);
            // 
            // NUDEditCostInStock
            // 
            this.NUDEditCostInStock.DecimalPlaces = 2;
            this.NUDEditCostInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDEditCostInStock.Location = new System.Drawing.Point(110, 271);
            this.NUDEditCostInStock.Maximum = new decimal(new int[] {
            1215752291,
            23,
            0,
            131072});
            this.NUDEditCostInStock.Name = "NUDEditCostInStock";
            this.NUDEditCostInStock.Size = new System.Drawing.Size(120, 22);
            this.NUDEditCostInStock.TabIndex = 5;
            this.NUDEditCostInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDEditCostInStock.ValueChanged += new System.EventHandler(this.NUDEditCostInStock_ValueChanged);
            // 
            // DGVInputEditInventory
            // 
            this.DGVInputEditInventory.AllowUserToAddRows = false;
            this.DGVInputEditInventory.AllowUserToDeleteRows = false;
            this.DGVInputEditInventory.AllowUserToResizeColumns = false;
            this.DGVInputEditInventory.AllowUserToResizeRows = false;
            this.DGVInputEditInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInputEditInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductID,
            this.ColProductName,
            this.ColProductCategory,
            this.ColPrice,
            this.ColTotalInStock,
            this.colCostInStock});
            this.DGVInputEditInventory.Location = new System.Drawing.Point(236, 113);
            this.DGVInputEditInventory.MultiSelect = false;
            this.DGVInputEditInventory.Name = "DGVInputEditInventory";
            this.DGVInputEditInventory.ReadOnly = true;
            this.DGVInputEditInventory.RowHeadersVisible = false;
            this.DGVInputEditInventory.RowHeadersWidth = 28;
            this.DGVInputEditInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVInputEditInventory.Size = new System.Drawing.Size(560, 294);
            this.DGVInputEditInventory.TabIndex = 7;
            this.DGVInputEditInventory.SelectionChanged += new System.EventHandler(this.DGVInputEditInventory_SelectionChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Navy;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(129, 313);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(86, 41);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ColProductID
            // 
            this.ColProductID.DataPropertyName = "ID";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.ColProductID.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColProductID.HeaderText = "ID";
            this.ColProductID.Name = "ColProductID";
            this.ColProductID.ReadOnly = true;
            this.ColProductID.Width = 40;
            // 
            // ColProductName
            // 
            this.ColProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColProductName.DataPropertyName = "Product Name";
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
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 65;
            // 
            // ColTotalInStock
            // 
            this.ColTotalInStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColTotalInStock.DataPropertyName = "Total In Stock";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.ColTotalInStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColTotalInStock.HeaderText = "Total In Stock";
            this.ColTotalInStock.Name = "ColTotalInStock";
            this.ColTotalInStock.ReadOnly = true;
            this.ColTotalInStock.Width = 99;
            // 
            // colCostInStock
            // 
            this.colCostInStock.DataPropertyName = "Cost In Stock";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.colCostInStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCostInStock.HeaderText = "Cost In Stock";
            this.colCostInStock.Name = "colCostInStock";
            this.colCostInStock.ReadOnly = true;
            this.colCostInStock.Width = 120;
            // 
            // FrmEditInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DGVInputEditInventory);
            this.Controls.Add(this.NUDEditCostInStock);
            this.Controls.Add(this.NUDEditInStock);
            this.Controls.Add(this.LblCostinStock);
            this.Controls.Add(this.LblINStock);
            this.Controls.Add(this.BtnEditClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBProductID);
            this.Controls.Add(this.ProductIDLbl);
            this.Controls.Add(this.NUDPrice);
            this.Controls.Add(this.TBCategory);
            this.Controls.Add(this.TBProductName);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductCategoryLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.LblEditInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditInventory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Inventory";
            this.Load += new System.EventHandler(this.FrmEditInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEditInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEditCostInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputEditInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEditInventory;
        private System.Windows.Forms.NumericUpDown NUDPrice;
        private System.Windows.Forms.TextBox TBCategory;
        private System.Windows.Forms.TextBox TBProductName;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBProductID;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.Button BtnEditClose;
        private System.Windows.Forms.Label LblINStock;
        private System.Windows.Forms.Label LblCostinStock;
        private System.Windows.Forms.NumericUpDown NUDEditInStock;
        private System.Windows.Forms.NumericUpDown NUDEditCostInStock;
        private System.Windows.Forms.DataGridView DGVInputEditInventory;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostInStock;
    }
}