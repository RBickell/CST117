using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIleStone2.Model
{
    public class Product
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int CatagoryID { get; set; }
        public Double Price { get; set; }
    }
}
