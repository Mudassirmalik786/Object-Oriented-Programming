using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskOne();
            //TaskTwo();
            //TaskThree();
            //TaskFour();
            //TaskFive();
            //TaskSix();
            //TaskSeven();
            //TaskEight();
            //TaskNine();
            //TaskTen();
            //TaskEleven();
            //Challenge1();
            Challenge2();
            Console.Read();
        }
        static void TaskOne()
        {
            student s1 = new student();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }
        static void TaskTwo()
        {
            student s1 = new student();
        }
        static void TaskThree()
        {
            studentTaskThree s1 = new studentTaskThree();
            Console.WriteLine(s1.sname);
        }
        static void TaskFour()
        {
            studentTaskFour s1 = new studentTaskFour();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }
        static void TaskFive()
        {
            studentTaskFive s1 = new studentTaskFive();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            studentTaskFive s2 = new studentTaskFive();
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
        }
        static void TaskSix()
        {
            studentTaskSix s1 = new studentTaskSix("John");
            Console.WriteLine(s1.sname);
            studentTaskSix s2 = new studentTaskSix("Jack");
            Console.WriteLine(s2.sname);
        }
        static void TaskSeven()
        {
            studentTaskSeven s1 = new studentTaskSeven("John",100,100,100,86);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }
        static void TaskEight()
        {
            studentTaskSeven s1 = new studentTaskSeven("John", 100, 100, 100, 86);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            studentTaskSeven s2 = new studentTaskSeven("Back", 90, 90, 90, 98);
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
        }
        static void TaskNine()
        {
            studentTaskNine s1 = new studentTaskNine();
            s1.sname = "Jack";
            studentTaskNine s2 = new studentTaskNine(s1);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);
        }
        static void TaskTen()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void TaskEleven()
        {
            clockType empty_time = new clockType();
            Console.Write("Empty time: ");
            empty_time.printTime();

            clockType hour_time = new clockType(8);
            Console.Write("Hour Time: ");
            hour_time.printTime();

            clockType minute_time = new clockType(8,10);
            Console.Write("Minute time: ");
            minute_time.printTime();

            clockType full_time = new clockType(8,10,10);
            Console.Write("Seconds time: ");
            full_time.printTime();

            full_time.incrementSecond();
            Console.Write("Full time (increment Second): ");
            full_time.printTime();
            
            full_time.incrementhours();
            Console.Write("Full time (increment Hours): ");
            full_time.printTime();
            
            full_time.incrementminutes();
            Console.Write("Full time (increment Minutes): ");
            full_time.printTime();

            bool flag = full_time.isEqual(9, 11, 11);
            Console.WriteLine("Flag" + flag);

            clockType cmp = new clockType(10, 12, 1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);
        }
        static void Challenge1()
        {
            //week3 Lab manual
            clockType full_time = new clockType(8, 10, 10);
            Console.Write("Elased time: ");
            full_time.printTime();

            clockType remainingTime = new clockType(8, 10, 10,24,60,60);
            Console.Write("Remaining time: ");
            remainingTime.printTime();

            clockType c1 = new clockType();// Copy Constructor
            c1.hours = 10;
            c1.minutes = 38;
            c1.seconds = 50;
            clockType c2 = new clockType();
            c2.hours = 8;
            c2.minutes = 30;
            c2.seconds = 48;
            if(c1.hours > c2.hours && c1.minutes > c2.minutes && c1.seconds > c2.seconds)
            {
                int totalHours = c1.hours - c2.hours;
                int totalMinutes = c1.minutes - c2.minutes;
                int totalSeconds = c1.seconds - c2.seconds;
                Console.Write("The difference between two clock is: ");
                Console.Write(totalHours + ":" + totalMinutes + ":" + totalSeconds);
            }
            else if (c2.hours > c1.hours && c2.minutes > c1.minutes && c2.seconds > c1.seconds)
            {
                int totalHours = c2.hours - c1.hours;
                int totalMinutes = c2.minutes - c1.minutes;
                int totalSeconds = c2.seconds - c1.seconds;
                Console.Write("The difference between two clock is: ");
                Console.Write(totalHours + ":" + totalMinutes + ":" + totalSeconds);
            }
            else
            {
                Console.WriteLine("Hours minutes and seconds of any clock must be higher than other");
            }
        }
        static void Challenge2()
        {
            product[] p = new product[10];
            int option = 0;
            int count = 0;
            do
            {
                option = menu();
                if (option == 1)
                {
                    //Add Product
                    Console.Clear();
                    p[count] = addProduct();
                    count = count + 1;
                    clearScreen();
                }
                else if (option == 2)
                {
                    //View All Products
                    viewProduct(p, count);
                }
                else if (option == 3)
                {
                    //Find product with highest unit price
                    Console.Clear();
                    topProductwithPrice(p, count);
                }
                else if (option == 4)
                {
                    //View Sales Tax
                    Console.Clear();
                    float sum = calculateSalesTax(p, count);
                    Console.WriteLine("The total sales tax of all products is: " + sum);
                    clearScreen();
                }
                else if (option == 5)
                {
                    //Products to be ordered
                    Console.Clear();
                    orderedProducts(p, count);
                    clearScreen();
                }
            } while (option != 6);
        }
        static void viewProduct(product[] p, int count)
        {
            Console.Clear();
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Name Of Product: {0}   Category: {1}    Price: {2}     Quantity of Product: {3}      Minimum Quantity available: {4}", p[x].p_name, p[x].p_category, p[x].p_price, p[x].p_quantity, p[x].p_minQuantity);
            }
            clearScreen();
        }
        static product addProduct()
        {
            product p1 = new product();
            Console.Write("Enter name of Product: ");
            p1.p_name = Console.ReadLine();
            Console.Write("Enter Category of Product(groceries/fresh-fruit/any other): ");
            p1.p_category = Console.ReadLine();
            Console.Write("Enter price of product: ");
            p1.p_price = float.Parse(Console.ReadLine());
            Console.Write("Enter quantity of Product: ");
            p1.p_quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter minimum number of that Product: ");
            p1.p_minQuantity = int.Parse(Console.ReadLine());
            return p1;
        }
        static int menu()
        {
            int option = 0;
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.View All Products");
            Console.WriteLine("3.Find Product with highest unit price");
            Console.WriteLine("4.View Sales Tax of All Products");
            Console.WriteLine("5.Products to be ordered");
            Console.WriteLine("6.Exit");
            Console.Write("Enter Your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void clearScreen()
        { 
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        static void topProductwithPrice(product[] p, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record present!!");
            }
            else if (count == 1)
            {
                viewProduct(p, 1);
            }
            else if (count == 2)
            {
                for (int x = 0; x < 2; x++)
                {
                    int index = largest(p, x, count);
                    product temp = p[index];
                    p[index] = p[x];
                    p[x] = temp;
                }
                viewProduct(p, 2);
            }
            else
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(p, x, count);
                    product temp = p[index];
                    p[index] = p[x];
                    p[x] = temp;
                }
                viewProduct(p, 2);
            }
        }
        static int largest(product[] p, int start, int end)
        {
            int index = start;
            float large = p[start].p_price;
            for (int x = start; x < end; x++)
            {
                if (large < p[x].p_price)
                {
                    large = p[x].p_price;
                    index = x;
                }
            }
            return index;
        }
        static float calculateSalesTax(product[] p, int count)
        {
            float sum = 0;
            for(int x = 0; x < count; x++)
            {
                if(p[x].p_category == "groceries")
                {
                    p[x].p_salesTax = (p[x].p_price * 10) / 100;
                    sum = sum + p[x].p_salesTax;
                    Console.WriteLine("Sales tax of " + p[x].p_name + " is: " + p[x].p_salesTax);
                }
                else if(p[x].p_category == "fresh-fruit")
                {
                    p[x].p_salesTax = (p[x].p_price * 5) / 100;
                    sum = sum + p[x].p_salesTax;
                    Console.WriteLine("Sales tax of " + p[x].p_name + " is: " + p[x].p_salesTax);
                }
                else
                {
                    p[x].p_salesTax = (p[x].p_price * 15) / 100;
                    sum = sum + p[x].p_salesTax;
                    Console.WriteLine("Sales tax of " + p[x].p_name + " is: " + p[x].p_salesTax);
                }
            }
            return sum;
        }
        static void orderedProducts(product[] p, int count)
        {
            for(int x = 0; x < count; x++)
            {
                if(p[x].p_minQuantity < 10)
                {
                    Console.WriteLine("Product: " + p[x].p_name + " should be ordered");
                }
            }
        }
    }
}
