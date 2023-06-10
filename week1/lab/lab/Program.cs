using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskOne();
            //TaskTwo();
            //TaskThree;
            //TaskFour();
            //TaskFive();
            //TaskSix();
            //TaskSeven();
            //TaskEight();
            //TaskNine();
            //TaskTen();
            //TaskEleven();
            //TaskTwelve();
            //TaskThirteen();
            //TaskFourteen();
            //TaskFifteen();
            //TaskSixteen();
            //TaskOnePd();
            //TaskTwoPd();
            //TaskThreePd();
            TaskFourPd();
            Console.Read();
        }
        static void TaskOne()
        {
            Console.Write("Hello World");
            Console.Write("Hello World");
        }
        static void TaskTwo()
        {
            Console.WriteLine("Hello World");
            Console.Write("Hello World");
        }
        static void TaskThree()
        {
            //integer Datatype
            int variable = 7;
            Console.WriteLine("Value: ");
            Console.Write(variable);
        }
        static void TaskFour()
        {
            float length;
            float area;
            Console.Write("Enter length: ");
            length = float.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("Area is: {0} ", area);
        }
        static void TaskFive()
        {
            float marks;
            Console.Write("Enter the Marks: ");
            marks = float.Parse(Console.ReadLine());
            if(marks > 50)
            {
                Console.WriteLine("You are passed");
            }
            else
            {
                Console.WriteLine("You are failed");
            }
        }
        static void TaskSix()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcom Jack");
            }
        }
        static void TaskSeven()
        {
            int number = 0;
            int sum = 0;
            do
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                if (number != -1)
                {
                    sum = sum + number;
                }
            }
            while (number != -1);
            Console.Write("Sum is: {0} ", sum);
        }
        static void TaskEight()
        {
            int[] numbers = new int[3];
            for(int x = 0; x<3; x++)
            {
                Console.Write("Enter a number {0}: ",x + 1);
                numbers[x] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for(int x = 0; x < 3; x++)
            {
                if(numbers[x] > largest)
                {
                    largest = numbers[x];
                }
            }
            Console.WriteLine("Largest is: {0}", largest);
        }
        static void TaskNine()
        {
            String test;
            Console.Write("Enter a string: ");
            test = Console.ReadLine();
            Console.WriteLine("String is: {0} ",test);
        }
        static void TaskTen()
        {
            float number;
            Console.Write("Enter a number: ");
            number = float.Parse(Console.ReadLine());
            Console.Write("Number is: {0}", number);
        }
        static void TaskEleven()
        {
            int money = 10;
            int ageOfLilly = 0; 
            int priceOfToy = 0;
            Console.Write("Enter age of lilly: ");
            ageOfLilly = int.Parse(Console.ReadLine());
            float priceOfWashingMachine;
            Console.Write("Enter price of Washing Machine: ");
            priceOfWashingMachine = float.Parse(Console.ReadLine());
            Console.Write("Enter unit price of Each toy: ");
            priceOfToy = int.Parse(Console.ReadLine());
            int oddBirthday = 0; 
            int evenBirthday = 0;
            int sum = 0;
            int store = 0;
            for(int x = 0; x <= ageOfLilly; x++)
            {
                if (x != 0)
                {
                    if (x % 2 == 0)
                    {
                        evenBirthday = evenBirthday + 1;
                        sum = sum + money;
                        store = store + sum;
                    }
                    else
                    {
                        oddBirthday++;
                    }
                }
            }
            int totalMoneyofToy = oddBirthday * priceOfToy;
            int totalMoney = store + totalMoneyofToy - evenBirthday;
            Console.WriteLine("Total Money Saved: {0} ", totalMoney);
            if (totalMoney > priceOfWashingMachine)
            {
                Console.Write("Yes {0}$ is remaining amount after purchase", totalMoney - priceOfWashingMachine);
            }
            else if(totalMoney < priceOfWashingMachine)
            {
                Console.Write("No {0}$ is required more to buy washing machine", priceOfWashingMachine - totalMoney);
            }
        }
        static void TaskTwelve()
        {
            int n1;
            int n2;
            Console.Write("Enter first number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            n2 = int.Parse(Console.ReadLine());
            int result = addition(n1, n2);
            Console.WriteLine("The Sum is: {0}", result);
        }
        static int addition(int n1, int n2)
        {
            return n1 + n2;
        }
        static void TaskThirteen()
        {
            StreamWriter fileVariable = new StreamWriter("C:/OOP/week1/lab/datafile.txt");
            fileVariable.WriteLine("Hello");
            fileVariable.Flush();
            fileVariable.Close();
        }
        static void TaskFourteen()
        {
            if (File.Exists("C:/OOP/week1/lab/datafile.txt"))
            {
                StreamReader fileVariable = new StreamReader("C:\\OOP\\week1\\lab\\datafile.txt");
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void TaskFifteen()
        {
            string path = "C:\\OOP\\week1\\lab\\textfile.txt";
            string[] names = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                readData(path, names, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.Write("Enter name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string p = Console.ReadLine();
                    SignIn(n, p, names, password);
                }
                else if (option == 2)
                {
                    Console.Write("Enter new Name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter new Password: ");
                    string p = Console.ReadLine();
                    SignUp(path, n, p);
                }
            }
            while (option != 3);
        } 
        static int menu()
        {
            int option;
            Console.WriteLine("*******************************");
            Console.WriteLine("****Practice SignIn & SignUp***");
            Console.WriteLine("*******************************");
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter any option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for(int x = 0; x< record.Length;x++)
            {
                if(record[x] == ',')
                {
                    comma++;
                }
                else if(comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void readData(string path, string [] names, string [] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if(x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void SignIn(string n, string p, string[] names, string [] password)
        {
            bool flag = false;
            for (int x = 0; x<5; x++)
            {
                if(n == names[x] && p == password[x])
                {
                    Console.WriteLine("Valid USer");
                    flag = true;
                }
            }
            if(flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void SignUp(string path , string n , string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.Flush();
            file.Close();
        }
        /*static void TaskSixteen()
        {
            string path = "C:\\OOP\\week1\\lab\\Customers.txt";
            Customers(path, records, field);
        }

        private static string Customers(string path, string records, int field)
        {
            StreamReader file = new StreamReader(path);
            string record;
            while((record = file.ReadLine()) != null)
            {
                int comma = 1;
                string item = "";
                for (int x = 0; x < records.Length; x++)
                {
                    if (record[x] == ',')
                    {
                        comma++;
                    }
                    else if (comma == field)
                    {
                        item = item + records[x];
                    }
                }
                return item;
            }
            file.Close();
        }
        static void PizzaPoints(int orders, int price)
        {
            if(orders == record && price == field)
            {

            } 
        }*/
        static void TaskOnePd() // Gives any random number
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next();
            Console.WriteLine(randomNumber);
        }
        static void TaskTwoPd() // Gives random number number between 0 and 100
        {
            Random rnd = new Random();
            int min = 0;
            int max = 100;
            int randomNumber = rnd.Next(min,max);
            Console.WriteLine(randomNumber);
        }
        static void TaskThreePd() // Gives random number between 0 and 1
        {
            Random rnd = new Random();
            double randomDouble = rnd.NextDouble();
            Console.WriteLine(randomDouble);
        }
        static void TaskFourPd() // Set colours on console
        {
            Console.WriteLine("This line is without colours!!!");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("This is dark magneta color!!!");
            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("This is blue color!!!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
