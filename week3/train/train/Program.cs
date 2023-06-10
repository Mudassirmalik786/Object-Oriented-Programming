using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MUser> users = new List<MUser>();
            List<Train> products = new List<Train>();
            string path = "E:\\OOP\\week3\\train\\users.txt";
            string path1 = "E:\\OOP\\week3\\train\\train.txt";
            int option;
            int choice;
            bool check = readData(path, users);
            bool check1 = readDataofTrain(path1, products);
            if (check)
                Console.WriteLine("Data Loaded SuccessFully");
            else
                Console.WriteLine("Data Not Loaded");
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    MUser user = takeInputWithoutRole();
                    if (user != null)
                    {
                        user = signIn(user, users);
                        if (user == null)
                        {
                            Console.WriteLine("Invalid User");
                        }
                        else if (user.isAdmin())
                        {
                            do
                            {
                                Console.WriteLine("Admin Menu");
                                choice = admin_menu();
                                if (choice == 1)
                                {
                                    //View Customer
                                    Console.Clear();
                                    viewCustomer(user, users);
                                }
                                else if (choice == 2)
                                {
                                    //Add train
                                    Console.Clear();
                                    if (check1)
                                        Console.WriteLine("Data Loaded");
                                    else
                                        Console.WriteLine("Data Not Loaded");
                                    Train product = takeInputForTrain();
                                    if (product != null)
                                    {
                                        storeTrainInFile(path1, product);
                                        storeTrainInList(products, product);
                                    }
                                }
                                else if (choice == 3)
                                {
                                    //Delete train
                                    Console.Clear();
                                    Train product = new Train();
                                    Console.Write("Enter the name of the train to delete: ");
                                    string trainNameToDelete = Console.ReadLine();
                                    DeleteTrain(path1, trainNameToDelete);
                                }
                                else if (choice == 4)
                                {
                                    //Update train
                                    Console.Clear();
                                    Console.Write("Enter train name you want to update: ");
                                    string name = Console.ReadLine();
                                    Console.Write("Enter New Schedule of train you want to update (Source-Destination): ");
                                    string newSchedule = Console.ReadLine();
                                    Console.Write("Enter train time you want to update (e.g.11:59pm): ");
                                    string newTime = Console.ReadLine();
                                    UpdateTrain(path1, name, newSchedule, newTime);
                                }

                            } while (choice != 5);
                        }
                        else
                        {
                            Console.WriteLine("User Menu");
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
            Console.Read();
        }
        
        static int menu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Option from the above mentioned options: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        
        static int admin_menu()
        {
            Console.Clear();
            int choice;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.View Users ");
            Console.WriteLine("2.Add a New item ");
            Console.WriteLine("3.Delete an Exisitng item ");
            Console.WriteLine("4.Update an Exisitng item");
            Console.WriteLine("5.Exit");
            Console.Write("Enter Option: ");
            choice = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            return choice;
        }

        static void UpdateTrain(string path1, string name, string newSchedule, string newTime)
        {
            // Load data from file
            List<Train> trains = new List<Train>();
            using (StreamReader reader = new StreamReader(path1))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    trains.Add(new Train(values[0], values[1], values[2]));
                }
            }

            // Find train to update
            Train trainToUpdate = trains.FirstOrDefault(train => train.tname == name);
            if (trainToUpdate != null)
            {
                trainToUpdate.tschedule = newSchedule;
                trainToUpdate.time = newTime;
            }

            // Write updated data to file
            using (StreamWriter writer = new StreamWriter(path1))
            {
                foreach (Train train in trains)
                {
                    writer.WriteLine($"{train.tname},{train.tschedule},{train.time}");
                }
            }
            clearScreen();
        }

        static void DeleteTrain(string path1, string trainNameToDelete)
        {
            // Load data from file
            List<Train> trains = new List<Train>();
            using (StreamReader reader = new StreamReader(path1))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    trains.Add(new Train(values[0], values[1], values[2]));
                }
            }

            // Find train to delete
            Train trainToDelete = trains.FirstOrDefault(train => train.tname == trainNameToDelete);
            if (trainToDelete != null)
            {
                trains.Remove(trainToDelete);
            }

            // Write updated data to file
            using (StreamWriter writer = new StreamWriter(path1))
            {
                foreach (Train train in trains)
                {
                    writer.WriteLine($"{train.tname},{train.tschedule},{train.time}");
                }
            }
            clearScreen();
        }

        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length;x++)
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
        static bool readDataofTrain(string path1, List<Train> products)
        {
            if (File.Exists(path1))
            {
                StreamReader fileVariable = new StreamReader(path1);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string tname = parseData(record, 1);
                    string tschedule = parseData(record, 2);
                    string time = parseData(record, 3);
                    Train product = new Train(tname, tschedule, time);
                    storeTrainInList(products, product);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        static MUser takeInputWithoutRole()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
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
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Role: ");
            string role = Console.ReadLine();
            if (name != null && password != null && role != null)
            {
                MUser user = new MUser(name, password, role);
                return user;
            }
            return null;
        }

        static Train takeInputForTrain()
        {
            Console.Write("Enter Name Of Train: ");
            string tname = Console.ReadLine();
            Console.Write("Enter Schedule (Source-Destination): ");
            string tschedule = Console.ReadLine();
            Console.Write("Enter Time of Train: ");
            string time = Console.ReadLine();
            if (tname != null && tschedule != null && time != null)
            {
                Train product = new Train(tname, tschedule, time);
                return product;
            }
            return null;
        }

        static void storeDataInList(List<MUser> users, MUser user)
        {
            users.Add(user);
        }

        static void storeTrainInList(List<Train> products, Train product)
        {
            products.Add(product);
        }

        static void storeDataInFile(string path, MUser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.name + "," + user.password + "," + user.role);
            file.Flush();
            file.Close();
        }

        static void storeTrainInFile(string path1, Train product)
        {
            StreamWriter file = new StreamWriter(path1, true);
            file.WriteLine(product.tname + "," + product.tschedule + "," + product.time);
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

        static void viewCustomer(MUser user, List<MUser> users)
        {
            Console.WriteLine("\t Name");
            foreach (MUser User in users)
            {
                Console.WriteLine($"\t {user.name}");
            }
            clearScreen();
        }
        
        static void clearScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    
    }
}
