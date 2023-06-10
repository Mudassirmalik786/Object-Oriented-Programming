using Challenge2.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MUser> users = new List<MUser>();
            List<Product> products = new List<Product>();
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer();
            string path = "textfile.txt";
            int option;
            int choice;
            bool check = readData(path, users);
            if (check)
                Console.WriteLine("Data Loaded SuccessFully");
            else
                Console.WriteLine("Data Not Loaded");
            Console.ReadKey();
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    MUser user = takeInputWithoutRole();
                    if (user != null)
                    {
                        user = signIn(user, users);
                        if (user == null)
                            Console.WriteLine("Invalid User");
                        else if (user.isAdmin())
                        {
                            do
                            {
                                choice = adminMenu();
                                if(choice == 1)
                                {
                                    addProducts(customer, customers);
                                }
                                else if(choice == 2)
                                {
                                    viewProducts(products);
                                }
                                else if (choice == 3)
                                {
                                    // Find product with highest unit price
                                }
                                else if (choice == 4)
                                {
                                    taxCalculate();
                                }
                                else if (choice == 5)
                                {
                                    //products to be ordered
                                }
                            } while (choice != 6);
                        }
                        else
                        {
                            Console.WriteLine("Customer Menu");
                            do
                            {
                                choice = customerMenu();
                                if (choice == 1)
                                {
                                    viewProducts(products);
                                }
                                else if (choice == 2)
                                {
                                    //Buy Product
                                }
                                else if (choice == 3)
                                {
                                    totalPrice(products, customers);
                                }
                            } while (choice != 4);
                        }
                    }
                }
                else if (option == 2)
                {
                    MUser user = takeInputWithRole();
                    if (user != null)
                    {
                        storeDataInFile(path, user);
                        storeDataInList(users, user);
                    }
                }
            }
            while (option != 3);
        }
        static void addProducts(Customer customer, List<Customer> customers)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter name of a product: ");
            string name = Console.ReadLine();
            Console.Write("Enter category of a product: ");
            string category = Console.ReadLine();
            Console.Write("Enter price of a product: ");
            int price = int.Parse(Console.ReadLine());
            Product product = new Product(name, category, price);
            customer.addProduct(product);
            addProductinList(products, product); 
        }
        static void viewProducts(List<Product> products)
        {
            Console.WriteLine(" Name\t\tCategory\t\tPrice ");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].name + "\t\t" + products[i].category + "\t\t" + products[i].price);
            }
        }
        static void addProductinList(List<Product> products, Product product)
        {
            products.Add(product);
        }
        static void taxCalculate()
        {
            Product product = new Product();
            float tax = product.calculateTax();
            Console.WriteLine("The tax on all products will be: " + tax);
        }
        static void totalPrice(List<Product> products, List<Customer> customers)
        {
            Product product = new Product();
            int totalprice = product.calculatePrice();
            for (int x = 0; x < products.Count; x++)
            {
                Console.WriteLine("The total bill of customer named " + customers[x].customerName + " is " + totalprice);
            }
        }
        static int customerMenu()
        {
            int option;
            Console.WriteLine("1. View all Products");
            Console.WriteLine("2. Buy the products");
            Console.WriteLine("3. Genenrate Invoice");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your desired option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static int adminMenu()
        {
            int option;
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be ordered");
            Console.WriteLine("6. Exit");
            Console.Write(" Enter Your Desired Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length;
            x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static bool readData(string path, List<MUser> users)

        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    MUser user = new MUser(name, password, role);
                    storeDataInList(users, user);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        static MUser takeInputWithoutRole()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if (name != null && password != null)
            {
                MUser user = new MUser(name, password);
                return user;
            }
            return null;
        }
        static MUser takeInputWithRole()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Role: ");
            string role = Console.ReadLine();
            if (name != null && password != null && role != null)
            {
                MUser user = new MUser(name, password, role);
                return user;
            }
            return null;
        }
        static void storeDataInList(List<MUser> users, MUser user)
        {
            users.Add(user);
        }
        static void storeDataInFile(string path, MUser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.name + "," + user.password + "," + user.role);
            file.Flush();
            file.Close();
        }
        static MUser signIn(MUser user, List<MUser> users)
        {
            foreach (MUser storedUser in users)
            {
                if (user.name == storedUser.name && user.password == storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }

    }
}
