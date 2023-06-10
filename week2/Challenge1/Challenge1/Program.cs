using Challenge1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Products[] p = new Products[10];
            int option;
            int count = 0;
            do
            {
                option = menu();
                if (option == 1)
                {
                    p[count] = addProducts();
                    count = count + 1;
                    Console.WriteLine("Press any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (option == 2)
                {
                    viewProducts(p, count);
                }
                else if (option == 3)
                {
                    calculatePrice(p, count);
                }
                else if (option == 4)
                {
                    break;
                }
                else 
                    Console.WriteLine("Invalid Choice");
            } while (option != 4);
            Console.WriteLine("Press Enter to exit..");
            Console.Read();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1.Add Products");
            Console.WriteLine("2.Show Products");
            Console.WriteLine("3.Total Store Worth");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter Your Option..");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static Products addProducts()
        {
            Console.Clear();
            Products p = new Products();
            Console.Write("Enter Product ID: ");
            p.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name Of Product: ");
            p.name = Console.ReadLine();
            Console.Write("Enter Price of Product: ");
            p.price = int.Parse(Console.ReadLine());
            Console.Write("Enter Category Of Product: ");
            p.category = Console.ReadLine();
            Console.Write("Enter Brand Name: ");
            p.brandName = Console.ReadLine();
            Console.Write("Enter Country of manufacturing: ");
            p.country = Console.ReadLine();
            return p;
        }
        static void viewProducts(Products[] p, int count)
        {
            Console.Clear();
            for(int i = 0; i < count; i++)
            {
                Console.Clear();
                Console.WriteLine("ID: {0} ", p[i].id);
                Console.WriteLine("Name: {0} ", p[i].name);
                Console.WriteLine("Price: {0} ", p[i].price);
                Console.WriteLine("Category: {0} ", p[i].category);
                Console.WriteLine("Brand Name: {0} ", p[i].brandName);
                Console.WriteLine("Country: {0} ", p[i].country);

            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }
    
        static void calculatePrice(Products[] p,int count)
        {
            Console.Clear();
            int totalPrice = 0;
            int x = 0;
            for(x =0; x <count; x++)
            {
                totalPrice = totalPrice + p[x].price;
            }

            Console.WriteLine("Total Price is: {0}", totalPrice);
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
