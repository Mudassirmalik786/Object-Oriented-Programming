using Problem1.BL;
using Problem1.DL;
using Problem1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = MenuUI.menu();
                if(option == 1)
                {
                    MenuUI.addIteminMenu();
                }
                else if(option == 2)
                {
                    MenuUI.cheapestItem();
                }
                else if (option == 3)
                {
                    MenuUI.viewDrinksMenu();
                }
                else if (option == 4)
                {
                    MenuUI.viewFoodItems();
                }
                else if (option == 5)
                {
                    MenuUI.addOrder();
                }
                else if (option == 6)
                {
                    CoffeeShop.fullfilOrders();
                }
                else if (option == 7)
                {
                    MenuUI.viewOrders();
                }
                else if (option == 8)
                {
                    MenuUI.amountDue();
                }
            } while(option != 9);
            Console.Read();
        }
    }
}
