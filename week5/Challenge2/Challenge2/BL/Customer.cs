using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class Customer
    {
        public string customerName;
        public string productName;
        public int quantity;
        public Customer(string customerName, string productName, int quantity)
        {
            this.customerName = customerName;
            this.productName = productName;
            this.quantity = quantity;
        }
        public Customer()
        {
        }
        List<Product> products = new List<Product>();
        public List<Product> getAllProducts()
        {
            return products;
        }
        public void addProduct(Product p)
        {
            products.Add(p);
        }
    }
}
