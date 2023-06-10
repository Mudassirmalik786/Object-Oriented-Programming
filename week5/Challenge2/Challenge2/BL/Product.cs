using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    public class Product
    {
        public string name;
        public string category;
        public int price;
        List<Product> products = new List<Product>();
        List<Customer> customers = new List<Customer>();
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
            for (int x = 0; x < products.Count; x++)
            {
                sum += products[x].price;
            }
            tax = sum * 10 / 100F;
            return tax;
        }
        public int calculatePrice()
        {
            int total = 0;
            for (int x = 0; x < products.Count; x++)
            {
                total = customers[x].quantity * products[x].price;
            }
            return total;
        }
    }
}