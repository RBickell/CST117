using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIleStone2.Model
{
    public class ProductsDetails : IProduct
    {
        public List<Product> ListOfproducts { get; set; }

        public bool Add(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Add(Product product, Catagory cat)
        {
            throw new NotImplementedException();
            // add SQL code here so that it will save to database
        }

        public bool Delete(int ID)
        {
            // add SQL code here so that it will save to database
            throw new NotImplementedException();
        }

        public Product GetProductByID(int productID)
        {
            throw new NotImplementedException();
            // add SQL code here so that it will save to database

        }

        public Product GetProductByName(string productName)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductList()
        {
            throw new NotImplementedException();
        }
    }

}
