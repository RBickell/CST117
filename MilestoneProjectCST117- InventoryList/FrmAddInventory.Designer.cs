namespace MilestoneProjectCST117__InventoryList
{
    partial class FrmAddInventory
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
            this.LblProductID = new System.Windows.Forms.Label();
            this.NUDAddStock = new System.Windows.Forms.NumericUpDown();
            this.NUDPrice = new System.Windows.Forms.NumericUpDown();
            this.TBCategory = new System.Windows.Forms.TextBox();
            this.TBProductName = new System.Windows.Forms.TextBox();
            this.AddToStockLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.BtnAddInventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseAddScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAddStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProductID
            // 
            this.LblProductID.AutoSize = true;
            this.LblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductID.Location = new System.Drawing.Point(202, 71);
            this.LblProductID.Name = "LblProductID";
            this.LblProductID.Size = new System.Drawing.Size(0, 20);
            this.LblProductID.TabIndex = 12;
            // 
            // NUDAddStock
            // 
            this.NUDAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAddStock.Location = new System.Drawing.Point(578, 146);
            this.NUDAddStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDAddStock.Name = "NUDAddStock";
            this.NUDAddStock.Size = new System.Drawing.Size(120, 26);
            this.NUDAddStock.TabIndex = 3;
            this.NUDAddStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NUDPrice
            // 
            this.NUDPrice.DecimalPlaces = 2;
            this.NUDPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDPrice.Location = new System.Drawing.Point(578, 107);
            this.NUDPrice.Name = "NUDPrice";
            this.NUDPrice.Size = new System.Drawing.Size(120, 26);
            this.NUDPrice.TabIndex = 2;
            this.NUDPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBCategory
            // 
            this.TBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCategory.Location = new System.Drawing.Point(206, 145);
            this.TBCategory.Name = "TBCategory";
            this.TBCategory.Size = new System.Drawing.Size(159, 26);
            this.TBCategory.TabIndex = 1;
            // 
            // TBProductName
            // 
            this.TBProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProductName.Location = new System.Drawing.Point(206, 106);
            this.TBProductName.Name = "TBProductName";
            this.TBProductName.Size = new System.Drawing.Size(159, 26);
            this.TBProductName.TabIndex = 0;
            // 
            // AddToStockLabel
            // 
            this.AddToStockLabel.AutoSize = true;
            this.AddToStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToStockLabel.Location = new System.Drawing.Point(437, 148);
            this.AddToStockLabel.Name = "AddToStockLabel";
            this.AddToStockLabel.Size = new System.Drawing.Size(118, 20);
            this.AddToStockLabel.TabIndex = 10;
            this.AddToStockLabel.Text = "Add to Stock:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(501, 109);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(54, 20);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price:";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryLabel.Location = new System.Drawing.Point(47, 151);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(153, 20);
            this.ProductCategoryLabel.TabIndex = 8;
            this.ProductCategoryLabel.Text = "Product Category:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(73, 109);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(127, 20);
            this.ProductNameLabel.TabIndex = 7;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(96, 73);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(100, 20);
            this.ProductIDLabel.TabIndex = 6;
            this.ProductIDLabel.Text = "Product ID:";
            // 
            // BtnAddInventory
            // 
            this.BtnAddInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddInventory.Location = new System.Drawing.Point(209, 195);
            this.BtnAddInventory.Name = "BtnAddInventory";
            this.BtnAddInventory.Size = new System.Drawing.Size(166, 55);
            this.BtnAddInventory.TabIndex = 4;
            this.BtnAddInventory.Text = "Add Inventory Item";
            this.BtnAddInventory.UseVisualStyleBackColor = false;
            this.BtnAddInventory.Click += new System.EventHandler(this.BtnAddInventory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Item into Inventory";
            // 
            // btnCloseAddScreen
            // 
            this.btnCloseAddScreen.BackColor = System.Drawing.Color.Black;
            this.btnCloseAddScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAddScreen.ForeColor = System.Drawing.Color.White;
            this.btnCloseAddScreen.Location = new System.Drawing.Point(419, 195);
            this.btnCloseAddScreen.Name = "btnCloseAddScreen";
            this.btnCloseAddScreen.Size = new System.Drawing.Size(166, 55);
            this.btnCloseAddScreen.TabIndex = 5;
            this.btnCloseAddScreen.Text = "Close Screen";
            this.btnCloseAddScreen.UseVisualStyleBackColor = false;
            this.btnCloseAddScreen.Click += new System.EventHandler(this.btnCloseAddScreen_Click);
            // 
            // FrmAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.btnCloseAddScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddInventory);
            this.Controls.Add(this.LblProductID);
            this.Controls.Add(this.NUDAddStock);
            this.Controls.Add(this.NUDPrice);
            this.Controls.Add(this.TBCategory);
            this.Controls.Add(this.TBProductName);
            this.Controls.Add(this.AddToStockLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductCategoryLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Name = "FrmAddInventory";
            this.Text = "Add to Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.NUDAddStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProductID;
        private System.Windows.Forms.NumericUpDown NUDAddStock;
        private System.Windows.Forms.NumericUpDown NUDPrice;
        private System.Windows.Forms.TextBox TBCategory;
        private System.Windows.Forms.TextBox TBProductName;
        private System.Windows.Forms.Label AddToStockLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Button BtnAddInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseAddScreen;
    }
}