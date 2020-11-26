using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestListfunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Products> LstProducts = new List<Products>();
        void txtclear()
        {
            TBProductName.Clear();
            TBCategory.Clear();
            NUDPrice.Value=0;
            NUDAddToStock.Value = 0;
        }
        
        
        public List<string> ListofProducts { get; set; }
        
        //public string Add()
        //{ 
        
        
        //}
        //MilestoneProjectCST117__InventoryList.Product Product = new Product();

        private void BtnAddInventory_Click(object sender, EventArgs e)
        {
           



            //List<row> Listofproducts = new List<Product>();
            //int num = Listofproducts[0];
            //int ResultId;
            //if (num > NID)
            //{
            //    NID = num
            //    }
            //Listofproducts.Add(num);
            //Listofproducts.Add(TBProductName.Text);
            //Listofproducts.Add(TBCategory.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddInventory_Click_1(object sender, EventArgs e)
        {

            //List<Products> LstProducts = new List<Products>();
            LstProducts.Add(new Products(TBProductName.Text, TBCategory.Text, NUDPrice.Value, NUDAddToStock.Value, NUDPrice.Value * NUDAddToStock.Value));
            //LstProducts[0].ProductName = TBProductName.Text;
            //LstProducts[0].Category = TBCategory.Text;
            //LstProducts[0].Price = NUDPrice.Value;
            //LstProducts[0].AddInStock = NUDAddToStock.Value;
            //LstProducts[0].CostInStock = NUDPrice.Value * NUDAddToStock.Value;
            BindingList<Products> bl = new BindingList<Products>(LstProducts);
            //BindingSource bs = new BindingSource(LstProducts,null);
            //bs.DataSource = LstProducts;
            DGVList.DataSource = bl;           
            
            //decimal Costinstock = NUDPrice.Value * NUDAddToStock.Value;

            //string[] row = { TBProductName.Text, TBCategory.Text, NUDPrice.Value.ToString(), NUDAddToStock.Value.ToString(), Costinstock.ToString() };
            //var listitem = new ListViewItem(row);
            //LVList.Rows.Add(listitem);
            //txtclear();
        }
    }
}
