using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask2
{
    class Customer
    {
        public string customerName;
        public string customerAddress;
        public string customerContact;
        public Customer(string customerName, string customerAddress, string customerContact)
        {
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerContact = customerContact;
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
    class Product
    {
        public string name;
        public string category;
        public int price;
        List<Product> products = new List<Product>();
        public Product(string name, string category, int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        public Product()
        {

        }
        public float calculateTax()
        {
            int sum = 0;
            float tax;
            for(int x = 0; x < products.Count; x++)
            {
                sum = sum + products[x].price;
            }
            tax = sum * 10 / 100F;
            return tax;
        }
        public int calculatePrice()
        {
            int sum = 0;
            for (int x = 0; x < products.Count; x++)
            {
                sum = sum + products[x].price;
            }
            return sum;
        }

    }
}
