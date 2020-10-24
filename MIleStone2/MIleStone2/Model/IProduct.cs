using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIleStone2.Model
{
    interface IProduct
    {
        Boolean Add(Product product );
        Boolean Delete(int ID);
        List<Product> GetProductList();
        Product GetProductByName(String productName);
        Product GetProductByID(int productID);


    }
}
