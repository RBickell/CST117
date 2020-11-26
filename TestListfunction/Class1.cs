using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListfunction
{
    class Products
    {
        private string productName;
        private string category;
        private decimal price;
        private decimal addInStock;
        private decimal costInStock;

        public string ProductName { get => productName; set => productName = value; }
        public string Category { get => category; set => category = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal AddInStock { get => addInStock; set => addInStock = value; }
        public decimal CostInStock { get => costInStock; set => costInStock = value; }

        public Products(string productName, string category, decimal price, decimal addInStock, decimal costInStock)
        {
            ProductName = productName;
            Category = category;
            Price = price;
            AddInStock = addInStock;
            CostInStock = costInStock;
        }
    }
}
