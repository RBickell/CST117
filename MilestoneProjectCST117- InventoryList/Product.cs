using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProjectCST117__InventoryList
{
    //Summary
    // This is the class that holds the declaration of the variables and methods
    

    public class Product
    {
        //Declaration Code:
        private int id;
        private string productName;
        private string category;
        private decimal price;
        private decimal addInStock;
        private decimal costInStock;

        public int ID { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Category { get => category; set => category = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal AddInStock { get => addInStock; set => addInStock = value; }
        public decimal CostInStock { get => costInStock; set => costInStock = value; }

        public Product(int id, string productName, string category, decimal price, decimal addInStock, decimal costInStock)
        {
            ID = id;
            ProductName = productName;
            Category = category;
            Price = price;
            AddInStock = addInStock;
            CostInStock = costInStock;
        }

        //Method Code:
        public static void BindDataGridViewToList(DataGridView DGV)
        {
            Program.bl.ResetBindings();
            DGV.DataSource = Program.bl;

        }

        public static int GetNewID()
        {
            int i = 0;
            foreach (Product prd in Program.LstPrd)
            {
                if (prd.id >= i)
                {
                    i = prd.id;
                }

            }
            return i + 1;
        }
    }
}
