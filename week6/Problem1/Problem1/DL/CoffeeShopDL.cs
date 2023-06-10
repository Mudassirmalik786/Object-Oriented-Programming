using Problem1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DL
{
    class CoffeeShopDL
    {
        public static List<MenuItem> listofitems = new List<MenuItem>();
        public static List<string> orders = new List<string>();
        static public void addmenuitems(MenuItem m)
        {
            listofitems.Add(m);
        }

        static public void addorders(string Itemname)
        {
            orders.Add(Itemname);
        }

        static public List<string> listorders()
        {
            return orders;
        }
    }
}
