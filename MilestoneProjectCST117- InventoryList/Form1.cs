using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MilestoneProjectCST117__InventoryList
{
    public partial class Form1 : Form
    {
        public class Product
        {
            public int ID { get; set; }
            public String Name { get; set; }
            public int CatagoryID { get; set; }
            public Double Price { get; set; }
            public Double TotalInStock { get; set; }
            public Double AddToStock;
            public Double DeletefromStock;

            public class ProductDetails
            {
                private string inputfile;

                public List<Product> Listofproducts { get; set; }
                public bool Add(Product Product)
                {
                    inputfile = "C:\\Users\\Raymo\\source\\repos\\MilestoneProjectCST117- InventoryList";
                    throw new NotImplementedException();
                }
                public bool Delete(int ID)
                {
                    inputfile = "C:\\Users\\Raymo\\source\\repos\\MilestoneProjectCST117- InventoryList";
                    throw new NotImplementedException();
                }
                public Product GetProductByID(int productID)
                {
                    throw new NotImplementedException();
                    inputfile = "C:\\Users\\Raymo\\source\\repos\\MilestoneProjectCST117- InventoryList";
                }
                public Product GetProductByName(String ProductName)
                {
                    inputfile = "C:\\Users\\Raymo\\source\\repos\\MilestoneProjectCST117- InventoryList";
                    throw new NotImplementedException();
                }
                public List<Product> GetProductList()
                {
                    inputfile = "C:\\Users\\Raymo\\source\\repos\\MilestoneProjectCST117- InventoryList"; throw new NotImplementedException();
                }

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductIDNumbox.Value = '0';
            ProductNameTextbox.Text = "";
            CategoryTextbox.Text = "";
            PriceNumbox.Value = '0';
            AddStockNumbox.Value = '0';
            DeleteStockNumbox.Value = '0';
            TotalStockNumbox.Value = '0';
        }


    }
}

