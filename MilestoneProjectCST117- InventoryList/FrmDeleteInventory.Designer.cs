namespace MilestoneProjectCST117__InventoryList
{
    partial class FrmDeleteInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVInputDeleteInventory = new System.Windows.Forms.DataGridView();
            this.BtnDeletefromInventory = new System.Windows.Forms.Button();
            this.BtnCloseFrmDeleteInventory = new System.Windows.Forms.Button();
            this.ColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputDeleteInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Row in Table to Delete from Inventory List";
            // 
            // DGVInputDeleteInventory
            // 
            this.DGVInputDeleteInventory.AllowUserToAddRows = false;
            this.DGVInputDeleteInventory.AllowUserToDeleteRows = false;
            this.DGVInputDeleteInventory.AllowUserToResizeColumns = false;
            this.DGVInputDeleteInventory.AllowUserToResizeRows = false;
            this.DGVInputDeleteInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInputDeleteInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductID,
            this.ColProductName,
            this.ColProductCategory,
            this.ColPrice,
            this.ColTotalInStock,
            this.colCostInStock});
            this.DGVInputDeleteInventory.Location = new System.Drawing.Point(82, 81);
            this.DGVInputDeleteInventory.Name = "DGVInputDeleteInventory";
            this.DGVInputDeleteInventory.ReadOnly = true;
            this.DGVInputDeleteInventory.RowHeadersVisible = false;
            this.DGVInputDeleteInventory.RowHeadersWidth = 28;
            this.DGVInputDeleteInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVInputDeleteInventory.Size = new System.Drawing.Size(643, 309);
            this.DGVInputDeleteInventory.TabIndex = 1;
            // 
            // BtnDeletefromInventory
            // 
            this.BtnDeletefromInventory.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDeletefromInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletefromInventory.ForeColor = System.Drawing.Color.White;
            this.BtnDeletefromInventory.Location = new System.Drawing.Point(133, 396);
            this.BtnDeletefromInventory.Name = "BtnDeletefromInventory";
            this.BtnDeletefromInventory.Size = new System.Drawing.Size(220, 52);
            this.BtnDeletefromInventory.TabIndex = 0;
            this.BtnDeletefromInventory.Text = "Delete From Inventory";
            this.BtnDeletefromInventory.UseVisualStyleBackColor = false;
            this.BtnDeletefromInventory.Click += new System.EventHandler(this.BtnDeletefromInventory_Click);
            // 
            // BtnCloseFrmDeleteInventory
            // 
            this.BtnCloseFrmDeleteInventory.BackColor = System.Drawing.Color.Black;
            this.BtnCloseFrmDeleteInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseFrmDeleteInventory.ForeColor = System.Drawing.Color.White;
            this.BtnCloseFrmDeleteInventory.Location = new System.Drawing.Point(471, 396);
            this.BtnCloseFrmDeleteInventory.Name = "BtnCloseFrmDeleteInventory";
            this.BtnCloseFrmDeleteInventory.Size = new System.Drawing.Size(184, 52);
            this.BtnCloseFrmDeleteInventory.TabIndex = 2;
            this.BtnCloseFrmDeleteInventory.Text = "Close";
            this.BtnCloseFrmDeleteInventory.UseVisualStyleBackColor = false;
            this.BtnCloseFrmDeleteInventory.Click += new System.EventHandler(this.BtnCloseFrmDeleteInventory_Click);
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
            this.ColProductName.ReadOnly = true;
            // 
            // ColProductCategory
            // 
            this.ColProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColProductCategory.DataPropertyName = "Category";
            this.ColProductCategory.HeaderText = "Category";
            this.ColProductCategory.Name = "ColProductCategory";
            this.ColProductCategory.ReadOnly = true;
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
            // FrmDeleteInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCloseFrmDeleteInventory);
            this.Controls.Add(this.BtnDeletefromInventory);
            this.Controls.Add(this.DGVInputDeleteInventory);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeleteInventory";
            this.Text = "Delete from Inventory";
            this.Load += new System.EventHandler(this.FrmDeleteInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInputDeleteInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVInputDeleteInventory;
        private System.Windows.Forms.Button BtnDeletefromInventory;
        private System.Windows.Forms.Button BtnCloseFrmDeleteInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostInStock;
    }
}