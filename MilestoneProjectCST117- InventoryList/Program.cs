using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProjectCST117__InventoryList
{
    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInventoryList());
        }

        public static int NID;
        public static string inputfile = "C:\\Users\\Raymo\\source\\repos\\CST117\\MilestoneProjectCST117- InventoryList\\ProductStorage.csv";

        public static DataTable PopulateDataTable()
        {
            DataTable dt = new DataTable();
            string[] file = File.ReadAllLines(inputfile);
            string[] data_col = null;
            int x = 0;
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Product Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("Price", typeof(Decimal));
            dt.Columns.Add("Total In Stock", typeof(Int32));
            dt.Columns.Add("Cost In Stock", typeof(Decimal));

            foreach (string line in file)
            {
                if (x == 0)
                {
                    x++;
                    continue;
                }
                data_col = line.Split(',');
                DataRow row = dt.NewRow();
                int N = Convert.ToInt32(data_col[0]);
                if (N > NID)
                {
                    NID = N;
                }
                row["ID"] = N;
                row["Product Name"] = Convert.ToString(data_col[1]);
                row["Category"] = Convert.ToString(data_col[2]);
                row["Price"] = Convert.ToDecimal(data_col[3]);
                row["Total In Stock"] = Convert.ToInt32(data_col[4]);
                row["Cost In Stock"] = Convert.ToDecimal(data_col[5]);
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
