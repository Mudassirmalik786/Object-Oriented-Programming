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
            List<Student> students = new List<Student>();
            int option;
            do
            {
                Console.Clear();
                option = menu();
                if(option == 1)
                {
                    Console.Clear();
                    Student student = takeInformation();
                    if (student != null)
                    {
                        storeDataInList(students, student);
                    }
                    clearScreen();
                }
                else if(option == 2)
                {
                    Student student = new Student();
                    float merit = student.calculateMerit();
                    Console.WriteLine("The merit of student is: ", merit);
                    clearScreen();
                }
                else if(option == 3)
                {
                    Student student = new Student();
                    float merit = student.calculateMerit();
                    bool found = student.isEligibleforScholarship(merit);
                    if(found == true)
                    {
                        Console.WriteLine("The Student is eligible for scholarship!!");
                    }
                    else
                    {
                        Console.WriteLine("The Student is not eligible for scholarship!!");
                    }
                    clearScreen();
                }
            } while (option != 4);
            Console.Read();
        }
            static int menu()
            {
                Console.Clear();
                int choice;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1.Add Student ");
                Console.WriteLine("2.View Merit ");
                Console.WriteLine("3.Scholarship Eligibility ");
                Console.WriteLine("4.Exit");
                Console.Write("Enter Option: ");
                choice = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Magenta;
                return choice;
            }
        static void storeDataInList(List<Student> students, Student student)
        {
            students.Add(student);
        }
        static Student takeInformation()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Roll Number: ");
            int rollNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your CGPA: ");
            float cGPA = float.Parse(Console.ReadLine());
            Console.Write("Enter your Matric Marks: ");
            int matricMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter your FSC Marks: ");
            int fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter your ECAT Marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter your Hometown: ");
            string hometown = Console.ReadLine();
            if (name != null && rollNumber != 0 && hometown != null)
            {
                Student student = new Student(name, rollNumber, cGPA, matricMarks, fscMarks, ecatMarks, hometown);
                return student;
            }
            return null;
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
