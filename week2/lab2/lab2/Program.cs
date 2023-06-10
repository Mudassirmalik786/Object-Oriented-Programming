using lab2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        class students
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            //TaskOne();
            //TaskTwo();
            //TaskThree();
            TaskFour();
            Console.Read();
        }
        static void TaskOne()
        {
            students s1 = new students();
            s1.name = "Mudassir";
            s1.roll_no = 5;
            s1.cgpa = 3.25F;
            Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2}",s1.name,s1.roll_no,s1.cgpa);
        }
        
        static void TaskTwo()
        {
            students s1 = new students();
            s1.name = "Mudassir";
            s1.roll_no = 5;
            s1.cgpa = 3.97F;
            Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2}", s1.name, s1.roll_no, s1.cgpa);
            students s2 = new students();
            s2.name = "ASAD";
            s2.roll_no = 10;
            s2.cgpa = 3.87F;
            Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2}", s2.name, s2.roll_no, s2.cgpa);
        }    
        
        static void TaskThree()
        {
            students s1 = new students();
            Console.WriteLine("Enter name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll no: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2}", s1.name, s1.roll_no, s1.cgpa);
        }

        static void TaskFour()
        {
            student[] s = new student[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addStudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewStudent(s, count);
                }
                else if (option == '3')
                {
                    topStudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
            }
            while (option != '4');
            Console.WriteLine("Press Enter to Exit..");
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1.Adding a student");
            Console.WriteLine("2.Viewing a students");
            Console.WriteLine("3.Top Three Students");
            Console.WriteLine("4.Exit");
            Console.Write("Enter your option: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static student addStudent()
        {
            Console.Clear();
            student s1 = new student();
            Console.Write("Enter name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter Roll Number: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Department: ");
            s1.department = Console.ReadLine();
            Console.Write("Is Hostellide(y/n): ");
            s1.isHostelide = char.Parse(Console.ReadLine());
            return s1;
        }
        static void viewStudent(student[] s, int count)
        {
            Console.Clear();
            for(int x = 0; x < count; x++)
            {
                Console.WriteLine("Name: {0} Roll No: {1} CGPA: {2} Department: {3} Hostellide: {4}",s[x].name,s[x].roll_no,s[x].cgpa,s[x].department,s[x].isHostelide);
                Console.WriteLine("Press any to continue..");
                Console.ReadKey();
            }
        }
        static void topStudent(student[] s, int count)
        {
            Console.Clear();
            if(count == 0)
            {
                Console.WriteLine("No Record present!!");
            }
            else if(count == 1)
            {
                viewStudent(s, 1);
            }
            else if(count == 2)
            {
                for(int x = 0; x < 2; x++)
                {
                    int index = largest(s, x, count);
                    student temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 2);
            }
            else
            {
                for(int x = 0; x< 3; x++)
                {
                    int index = largest(s, x, count);
                    student temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 2);
            }
        }
        static int largest(student[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for(int x =start; x< end; x++)
            {
                if (large < s[x].cgpa)
                {
                    large = s[x].cgpa;
                    index = x;
                }
            }
            return index;
        }
    }
}
