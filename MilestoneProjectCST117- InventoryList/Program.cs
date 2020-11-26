using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Application.Run(new FormMain());
        }
        public static List<Product> LstPrd=new List<Product>();
        public static BindingList<Product> bl=new BindingList<Product>(LstPrd);
       
        public static int NID;
        public static string inputfile = "C:\\Users\\Raymo\\source\\repos\\CST117\\MilestoneProjectCST117- InventoryList\\ProductStorage.csv";

        
    }
}
