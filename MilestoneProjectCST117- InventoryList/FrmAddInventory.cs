using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProjectCST117__InventoryList
{
    
    public partial class FrmAddInventory : Form
    {
        public FrmAddInventory()
        {
            InitializeComponent();
        }
        private int NID;
        DataTable tbl = new DataTable();

        private void btnCloseAddScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddInventory_Click(object sender, EventArgs e)
        {
            string inputfile = "C:\\Users\\Raymo\\source\\repos\\CST117\\MilestoneProjectCST117- InventoryList\\ProductStorage.csv";
            Product prd = new Product();
            prd.ID = NID++;
            prd.Name = TBProductName.Text;
            prd.Category = TBCategory.Text;
            prd.Price = NUDPrice.Value;
            prd.AddToStock = NUDAddStock.Value;
            prd.Dt = Program.PopulateDataTable();
            prd.Intputfile = inputfile;

            Product.ProductDetails prddet = new Product.ProductDetails();
            MessageBox.Show(prddet.Add(prd));

        }
    }
}
