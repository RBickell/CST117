using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Milestone_Project__Inventory_List
{
    public class ProductList
    {
        public int ProductID { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int TotalAmount { get; set; }
        public int InUse { get; set; }
        public int Availability { get; set; }
        public int Price { get; set; }
        public int CostInUse { get; set; }
        public int CostTotalAmount { get; set; }
    }
}
