namespace TestListfunction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblProductName = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.LblAddToStock = new System.Windows.Forms.Label();
            this.TBProductName = new System.Windows.Forms.TextBox();
            this.TBCategory = new System.Windows.Forms.TextBox();
            this.NUDPrice = new System.Windows.Forms.NumericUpDown();
            this.NUDAddToStock = new System.Windows.Forms.NumericUpDown();
            this.BtnAddInventory = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DGVList = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCostInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAddToStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductName.Location = new System.Drawing.Point(99, 63);
            this.LblProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(127, 20);
            this.LblProductName.TabIndex = 0;
            this.LblProductName.Text = "Product Name:";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(140, 100);
            this.LblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(86, 20);
            this.LblCategory.TabIndex = 1;
            this.LblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(551, 63);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // LblAddToStock
            // 
            this.LblAddToStock.AutoSize = true;
            this.LblAddToStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddToStock.Location = new System.Drawing.Point(483, 100);
            this.LblAddToStock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblAddToStock.Name = "LblAddToStock";
            this.LblAddToStock.Size = new System.Drawing.Size(122, 20);
            this.LblAddToStock.TabIndex = 3;
            this.LblAddToStock.Text = "Add To Stock:";
            // 
            // TBProductName
            // 
            this.TBProductName.Location = new System.Drawing.Point(225, 63);
            this.TBProductName.Name = "TBProductName";
            this.TBProductName.Size = new System.Drawing.Size(181, 26);
            this.TBProductName.TabIndex = 4;
            this.TBProductName.Text = "Desk";
            this.TBProductName.TextChanged += new System.EventHandler(this.TBProductName_TextChanged);
            // 
            // TBCategory
            // 
            this.TBCategory.Location = new System.Drawing.Point(225, 100);
            this.TBCategory.Name = "TBCategory";
            this.TBCategory.Size = new System.Drawing.Size(181, 26);
            this.TBCategory.TabIndex = 5;
            this.TBCategory.Text = "Furniture";
            // 
            // NUDPrice
            // 
            this.NUDPrice.DecimalPlaces = 2;
            this.NUDPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NUDPrice.Location = new System.Drawing.Point(627, 61);
            this.NUDPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDPrice.Name = "NUDPrice";
            this.NUDPrice.Size = new System.Drawing.Size(120, 26);
            this.NUDPrice.TabIndex = 6;
            this.NUDPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDPrice.Value = new decimal(new int[] {
            39500,
            0,
            0,
            131072});
            // 
            // NUDAddToStock
            // 
            this.NUDAddToStock.Location = new System.Drawing.Point(627, 101);
            this.NUDAddToStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDAddToStock.Name = "NUDAddToStock";
            this.NUDAddToStock.Size = new System.Drawing.Size(120, 26);
            this.NUDAddToStock.TabIndex = 7;
            this.NUDAddToStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUDAddToStock.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // BtnAddInventory
            // 
            this.BtnAddInventory.Location = new System.Drawing.Point(244, 152);
            this.BtnAddInventory.Name = "BtnAddInventory";
            this.BtnAddInventory.Size = new System.Drawing.Size(149, 39);
            this.BtnAddInventory.TabIndex = 8;
            this.BtnAddInventory.Text = "Add to Inventory";
            this.BtnAddInventory.UseVisualStyleBackColor = true;
            this.BtnAddInventory.Click += new System.EventHandler(this.BtnAddInventory_Click_1);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(472, 154);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(149, 37);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DGVList
            // 
            this.DGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ColCategory,
            this.ColPrice,
            this.ColInStock,
            this.ColCostInStock});
            this.DGVList.Location = new System.Drawing.Point(177, 213);
            this.DGVList.Name = "DGVList";
            this.DGVList.Size = new System.Drawing.Size(665, 232);
            this.DGVList.TabIndex = 10;
            this.DGVList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // ColCategory
            // 
            this.ColCategory.DataPropertyName = "Category";
            this.ColCategory.HeaderText = "Category";
            this.ColCategory.Name = "ColCategory";
            this.ColCategory.Width = 150;
            // 
            // ColPrice
            // 
            this.ColPrice.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.ColPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.Name = "ColPrice";
            // 
            // ColInStock
            // 
            this.ColInStock.DataPropertyName = "AddInStock";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColInStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColInStock.HeaderText = "In Stock";
            this.ColInStock.Name = "ColInStock";
            // 
            // ColCostInStock
            // 
            this.ColCostInStock.DataPropertyName = "Costinstock";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.ColCostInStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColCostInStock.HeaderText = "Cost In Stock";
            this.ColCostInStock.Name = "ColCostInStock";
            this.ColCostInStock.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.DGVList);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddInventory);
            this.Controls.Add(this.NUDAddToStock);
            this.Controls.Add(this.NUDPrice);
            this.Controls.Add(this.TBCategory);
            this.Controls.Add(this.TBProductName);
            this.Controls.Add(this.LblAddToStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.LblProductName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAddToStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label LblAddToStock;
        private System.Windows.Forms.TextBox TBProductName;
        private System.Windows.Forms.TextBox TBCategory;
        private System.Windows.Forms.NumericUpDown NUDPrice;
        private System.Windows.Forms.NumericUpDown NUDAddToStock;
        private System.Windows.Forms.Button BtnAddInventory;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView DGVList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCostInStock;
    }
}

