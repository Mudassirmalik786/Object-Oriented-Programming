using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Credentials[] c = new Credentials[10];
            string[] username = new string[10];
            string[] passWord = new string[10];
            string path = "C:\\OOP\\week2\\Challenge2\\Credentials.txt";
            int option;
            do
            {
                readData(path,username,passWord);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.Write("Enter your UserNAme: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter your Password: ");
                    string p = Console.ReadLine();
                    SignIn(n, p,username,passWord);
                }
                else if (option == 2)
                {
                    c[count]=SignUp(path,count);
                    count = count + 1;
                }
            }
            while (option != 3);
        }
        static int menu()
        {
            int option;
            Console.WriteLine("********************************************");
            Console.WriteLine("****SignIn & SignUp With Class and Object***");
            Console.WriteLine("********************************************");
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exit");
            Console.Write("Enter any option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
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
        static void readData(string path, string[] username,string[] passWord)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                { 
                    username[x] = parseData(record, 1);
                    passWord[x] = parseData(record, 2);
                    x++;
                    if (x >= 10)
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
        static void SignIn(string n, string p, string[] username, string[] passWord)
        { 
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n == username[x] && p == passWord[x])
                {
                    Console.WriteLine("Valid USer");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static Credentials SignUp(string path,int count)
        {
            Credentials c = new Credentials();
            Console.Write("Enter your name: ");
            c.userName = Console.ReadLine();
            Console.Write("Enter your Password: ");
            c.password = Console.ReadLine();
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(c.userName + "," + c.password);
            file.Flush();
            file.Close();
            return c;
        }
    }
}
