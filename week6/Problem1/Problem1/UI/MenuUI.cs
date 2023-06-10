using Problem1.BL;
using Problem1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.UI
{
    class MenuUI
    {
        public static int menu()
        {
            Console.WriteLine("****Welcome To The Tesha's Coffee Shop***");
            Console.WriteLine("1.Add Menu Item");
            Console.WriteLine("2.View The Cheapest Item in the menu");
            Console.WriteLine("3.View the Drink's Menu");
            Console.WriteLine("4.View the Food's Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("7.View the Order's List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.Write("Enter your desired option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static void addOrder()
        {
            Console.Write("Enter name of item: ");
            string itemname = Console.ReadLine();
            CoffeeShopDL.addorders(itemname);
            Console.WriteLine("Order Successfully added!!");
            clearScreen();
        }
        public static void cheapestItem()
        {
            string cheapest = CoffeeShop.cheappestitem();
            Console.WriteLine("The cheapest item in menu is: ");
        }
        public static void addIteminMenu()
        {
            Console.Write("Enter the name of item: ");
            string name = Console.ReadLine();
            Console.Write("Enter the type of item: ");
            string type = Console.ReadLine();
            Console.Write("Enter the price of item: ");
            int price = int.Parse(Console.ReadLine());
            MenuItem menuItem = new MenuItem(name, type, price);
            CoffeeShopDL.addmenuitems(menuItem);
            clearScreen();
        }
        public static void viewDrinksMenu()
        {
            CoffeeShop coffeeShop = new CoffeeShop();
            List<string> a = new List<string>();
            a = coffeeShop.drinkonly();
            Console.WriteLine("Following are the drink only items :" + a);
            clearScreen();
        }
        public static void viewFoodItems()
        {
            CoffeeShop coffeeShop = new CoffeeShop();
            List<string> a = new List<string>();
            a = coffeeShop.foodonly();
            Console.WriteLine("Following are the food items :" + a);
            clearScreen();
        }
        public static void viewOrders()
        {
            List<string> a = new List<string>();
            a = CoffeeShopDL.listorders();
            Console.WriteLine("Following are the orders: " + a);
            clearScreen();
        }
        public static void amountDue()
        {
            CoffeeShop coffeeShop = new CoffeeShop();
            double amount = coffeeShop.dueamount();
            Console.WriteLine("The amount due is : " + amount);
            clearScreen();
        }
    }
}
