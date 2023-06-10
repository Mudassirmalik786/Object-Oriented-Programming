using Problem1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    class CoffeeShop
    {
        public string shopname;

        public CoffeeShop(string shopname)
        {
            this.shopname = shopname;
        }
        public CoffeeShop()
        {
        }

        static public void fullfilOrders()
        {
            if (CoffeeShopDL.orders.Count > 0)
            {
                string item = CoffeeShopDL.orders[0];
                CoffeeShopDL.orders.RemoveAt(0);
                Console.WriteLine("This" + item + "is ready!");
            }
            else
            {
                Console.WriteLine("This order has been fulfilled");
            }
        }

        public double dueamount()
        {
            double amount = 0.0;
            MenuItem m = new MenuItem();
            foreach (string item in CoffeeShopDL.orders)
            {
                if (item != null)
                {
                    amount += m.price;
                }
            }
            return amount;
        }

        public static string cheappestitem()
        {
            string cheapitemname = null;
            double cheapestitemprice = 0.0;
            foreach (MenuItem i in CoffeeShopDL.listofitems)
            {
                if (i.price < cheapestitemprice)
                {
                    cheapestitemprice = i.price;
                    cheapitemname = i.name;
                }
            }
            return cheapitemname;
        }

        public List<string> drinkonly()
        {
            List<string> a = new List<string>();
            foreach (MenuItem i in CoffeeShopDL.listofitems)
            {
                if (i.type == "drink")
                {
                    a.Add(i.type);
                }
            }
            return a;
        }

        public List<string> foodonly()
        {
            List<string> a = new List<string>();
            foreach (MenuItem i in CoffeeShopDL.listofitems)
            {
                if (i.type == "food")
                {
                    a.Add(i.type);
                }
            }
            return a;
        }
    }
}
