using System;

namespace Milestone_Project__Inventory_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InventoryListLabel = new System.Windows.Forms.Label();
            this.SearchBoxLabel = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.AvailLabel = new System.Windows.Forms.Label();
            this.PriceSearchBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CategorySearchBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ProductSearchbox = new System.Windows.Forms.ComboBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.Sort2Label = new System.Windows.Forms.Label();
            this.SecondSortByBox = new System.Windows.Forms.ComboBox();
            this.FirstSortbyBox = new System.Windows.Forms.ComboBox();
            this.Sort1Label = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.ExitProgramButton = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostInUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBoxLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryListLabel
            // 
            this.InventoryListLabel.AutoSize = true;
            this.InventoryListLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InventoryListLabel.Location = new System.Drawing.Point(221, 9);
            this.InventoryListLabel.Name = "InventoryListLabel";
            this.InventoryListLabel.Size = new System.Drawing.Size(304, 37);
            this.InventoryListLabel.TabIndex = 0;
            this.InventoryListLabel.Text = "CAA Inventory List";
            // 
            // SearchBoxLabel
            // 
            this.SearchBoxLabel.Controls.Add(this.numericUpDown1);
            this.SearchBoxLabel.Controls.Add(this.button1);
            this.SearchBoxLabel.Controls.Add(this.AvailLabel);
            this.SearchBoxLabel.Controls.Add(this.PriceSearchBox);
            this.SearchBoxLabel.Controls.Add(this.PriceLabel);
            this.SearchBoxLabel.Controls.Add(this.CategorySearchBox);
            this.SearchBoxLabel.Controls.Add(this.CategoryLabel);
            this.SearchBoxLabel.Controls.Add(this.ProductSearchbox);
            this.SearchBoxLabel.Controls.Add(this.ProductLabel);
            this.SearchBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBoxLabel.Location = new System.Drawing.Point(12, 52);
            this.SearchBoxLabel.Name = "SearchBoxLabel";
            this.SearchBoxLabel.Size = new System.Drawing.Size(776, 65);
            this.SearchBoxLabel.TabIndex = 1;
            this.SearchBoxLabel.TabStop = false;
            this.SearchBoxLabel.Text = "Search By:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(588, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 25);
            this.numericUpDown1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(681, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "View Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AvailLabel
            // 
            this.AvailLabel.AutoSize = true;
            this.AvailLabel.Location = new System.Drawing.Point(509, 31);
            this.AvailLabel.Name = "AvailLabel";
            this.AvailLabel.Size = new System.Drawing.Size(82, 17);
            this.AvailLabel.TabIndex = 2;
            this.AvailLabel.Text = "Availability:";
            // 
            // PriceSearchBox
            // 
            this.PriceSearchBox.FormattingEnabled = true;
            this.PriceSearchBox.Location = new System.Drawing.Point(424, 28);
            this.PriceSearchBox.Name = "PriceSearchBox";
            this.PriceSearchBox.Size = new System.Drawing.Size(70, 25);
            this.PriceSearchBox.TabIndex = 3;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(386, 31);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(42, 17);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price:";
            // 
            // CategorySearchBox
            // 
            this.CategorySearchBox.FormattingEnabled = true;
            this.CategorySearchBox.Location = new System.Drawing.Point(263, 28);
            this.CategorySearchBox.Name = "CategorySearchBox";
            this.CategorySearchBox.Size = new System.Drawing.Size(106, 25);
            this.CategorySearchBox.TabIndex = 2;
            this.CategorySearchBox.SelectedIndexChanged += new System.EventHandler(this.CategorySearchBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.Location = new System.Drawing.Point(198, 31);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(68, 17);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category:";
            // 
            // ProductSearchbox
            // 
            this.ProductSearchbox.FormattingEnabled = true;
            this.ProductSearchbox.Location = new System.Drawing.Point(78, 28);
            this.ProductSearchbox.Name = "ProductSearchbox";
            this.ProductSearchbox.Size = new System.Drawing.Size(99, 25);
            this.ProductSearchbox.TabIndex = 2;
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductLabel.Location = new System.Drawing.Point(6, 31);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(66, 17);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Products:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SortButton);
            this.groupBox1.Controls.Add(this.Sort2Label);
            this.groupBox1.Controls.Add(this.SecondSortByBox);
            this.groupBox1.Controls.Add(this.FirstSortbyBox);
            this.groupBox1.Controls.Add(this.Sort1Label);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group By:";
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.Teal;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SortButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SortButton.Location = new System.Drawing.Point(209, 27);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(66, 50);
            this.SortButton.TabIndex = 8;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = false;
            // 
            // Sort2Label
            // 
            this.Sort2Label.AutoSize = true;
            this.Sort2Label.Location = new System.Drawing.Point(6, 61);
            this.Sort2Label.Name = "Sort2Label";
            this.Sort2Label.Size = new System.Drawing.Size(83, 17);
            this.Sort2Label.TabIndex = 7;
            this.Sort2Label.Text = "2nd Sort By:";
            // 
            // SecondSortByBox
            // 
            this.SecondSortByBox.FormattingEnabled = true;
            this.SecondSortByBox.Location = new System.Drawing.Point(93, 58);
            this.SecondSortByBox.Name = "SecondSortByBox";
            this.SecondSortByBox.Size = new System.Drawing.Size(113, 25);
            this.SecondSortByBox.TabIndex = 5;
            // 
            // FirstSortbyBox
            // 
            this.FirstSortbyBox.FormattingEnabled = true;
            this.FirstSortbyBox.Location = new System.Drawing.Point(93, 27);
            this.FirstSortbyBox.Name = "FirstSortbyBox";
            this.FirstSortbyBox.Size = new System.Drawing.Size(113, 25);
            this.FirstSortbyBox.TabIndex = 6;
            // 
            // Sort1Label
            // 
            this.Sort1Label.AutoSize = true;
            this.Sort1Label.Location = new System.Drawing.Point(6, 30);
            this.Sort1Label.Name = "Sort1Label";
            this.Sort1Label.Size = new System.Drawing.Size(78, 17);
            this.Sort1Label.TabIndex = 3;
            this.Sort1Label.Text = "1st Sort By:";
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddProductButton.Location = new System.Drawing.Point(329, 150);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(91, 50);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteProductButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteProductButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteProductButton.Location = new System.Drawing.Point(450, 149);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(91, 50);
            this.DeleteProductButton.TabIndex = 4;
            this.DeleteProductButton.Text = "Delete Product";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            // 
            // EditProductButton
            // 
            this.EditProductButton.BackColor = System.Drawing.Color.Navy;
            this.EditProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditProductButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditProductButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditProductButton.Location = new System.Drawing.Point(568, 149);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(91, 51);
            this.EditProductButton.TabIndex = 5;
            this.EditProductButton.Text = "Edit Product";
            this.EditProductButton.UseVisualStyleBackColor = false;
            // 
            // ExitProgramButton
            // 
            this.ExitProgramButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitProgramButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitProgramButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitProgramButton.Location = new System.Drawing.Point(687, 149);
            this.ExitProgramButton.Name = "ExitProgramButton";
            this.ExitProgramButton.Size = new System.Drawing.Size(87, 51);
            this.ExitProgramButton.TabIndex = 7;
            this.ExitProgramButton.Text = "Exit Program";
            this.ExitProgramButton.UseVisualStyleBackColor = false;
            this.ExitProgramButton.Click += new System.EventHandler(this.ExitProgramButton_Click);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ProductNameI
            // 
            this.ProductNameI.HeaderText = "Product";
            this.ProductNameI.Name = "ProductNameI";
            this.ProductNameI.ReadOnly = true;
            this.ProductNameI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TotalInStock
            // 
            this.TotalInStock.HeaderText = "Total In Stock";
            this.TotalInStock.Name = "TotalInStock";
            this.TotalInStock.ReadOnly = true;
            this.TotalInStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TotalInUse
            // 
            this.TotalInUse.HeaderText = "Total In Use";
            this.TotalInUse.Name = "TotalInUse";
            this.TotalInUse.ReadOnly = true;
            this.TotalInUse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            this.Availability.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CostInUse
            // 
            this.CostInUse.HeaderText = "Cost In Stock";
            this.CostInUse.Name = "CostInUse";
            this.CostInUse.ReadOnly = true;
            this.CostInUse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CostInStock
            // 
            this.CostInStock.HeaderText = "Cost In Use";
            this.CostInStock.Name = "CostInStock";
            this.CostInStock.ReadOnly = true;
            this.CostInStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 601);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductNameI,
            this.Category,
            this.TotalInStock,
            this.TotalInUse,
            this.Availability,
            this.Price,
            this.CostInUse,
            this.CostInStock});
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 360);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitProgramButton);
            this.Controls.Add(this.EditProductButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchBoxLabel);
            this.Controls.Add(this.InventoryListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SearchBoxLabel.ResumeLayout(false);
            this.SearchBoxLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CategorySearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
           

        }

        #endregion

        private System.Windows.Forms.Label InventoryListLabel;
        private System.Windows.Forms.GroupBox SearchBoxLabel;
        private System.Windows.Forms.Label AvailLabel;
        private System.Windows.Forms.ComboBox PriceSearchBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox ProductSearchbox;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.ComboBox CategorySearchBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Sort1Label;
        private System.Windows.Forms.Label Sort2Label;
        private System.Windows.Forms.ComboBox SecondSortByBox;
        private System.Windows.Forms.ComboBox FirstSortbyBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button EditProductButton;
        private System.Windows.Forms.Button ExitProgramButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostInUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostInStock;

        public EventHandler numericUpDown1_ValueChanged { get; private set; }
        public EventHandler PriceSearchBox_SelectedIndexChanged { get; private set; }
        public EventHandler ProductSearchbox_SelectedIndexChanged { get; private set; }
    }
}

