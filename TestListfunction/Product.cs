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
using System.Windows.Markup;

namespace MilestoneProjectCST117__InventoryList
{
    public class Product
    {
        private int iD;
        private string name;
        private string category;
        private decimal price;
        private decimal totalInStock;
        private decimal addToStock;
        private decimal deletefromStock;
        private decimal costInStock;
        private string intputfile;
        private DataTable dt;
        public static int NID;
        int N;

        string inputfile = "C:\\Users\\Raymo\\source\\repos\\CST117\\MilestoneProjectCST117- InventoryList\\ProductStorage.csv";
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal TotalInStock { get => totalInStock; set => totalInStock = value; }
        public decimal AddToStock { get => addToStock; set => addToStock = value; }
        public decimal DeletefromStock { get => deletefromStock; set => deletefromStock = value; }
        public decimal CostInStock { get => costInStock; set => costInStock = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string Intputfile { get => intputfile; set => intputfile = value; }

        public class ProductDetails
        {


            public List<Product> Listofproducts { get; set; }
            //public string Add(Product Product)
            //{
                //List<Product> Listofproducts = new List<Product>();
                //int num = Listofproducts[0];
                //int ResultId;
                //if (num > NID)
                //{ 
                //    NID=num
                //}
                //Listofproducts.Add(num);
                //Listofproducts.Add(TBProductName.Text);
                //Listofproducts.Add(TBCategory.Text);





                //return "Add Successful";
            }


            private static void AddRowToTable(string[] valueCollaction, char delimiter, ref DataTable tbl)
            {
                for (int i = 0; i < valueCollaction.Length; i++)
                {
                    string[] Values = valueCollaction[i].Split(delimiter);
                    DataRow tblr = tbl.NewRow();
                    for (int j = 0; j < Values.Length; j++)
                    {
                        tblr[j] = Values[j];
                    }
                    tbl.Rows.Add(tblr);
                }
            }
            public int TotalInStockCal(int Totalnum, int Addnum, int subnum)
            {
                return Totalnum + Addnum - subnum;
            }
            public Decimal CostInStockCal(int TotalInStock, Decimal StockPricenum)
            {
                return TotalInStock * StockPricenum;
            }
        }
    }
//}