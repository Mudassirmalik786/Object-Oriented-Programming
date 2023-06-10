using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labChallenge1
{
    class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<Student> sortedStudentList = new List<Student>();
        static List<DegreeProgram> programList = new List<DegreeProgram>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = menu();
                clearScreen();
                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    addIntoDegreeList(d);
                }
                else if (option == 3)
                {
                    sortStudentsByMerit();
                    giveAdmission();
                    printStudents();
                }
                else if (option == 4)
                {
                    viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name);
                    if (s != null)
                    {
                        s.viewSubjects();
                        registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    calculateFee();
                }
                
                clearScreen();
            }
            while (option != 8);
            Console.ReadKey();
        }

        static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }

        static void addIntoStudentList(Student s)
        {
            studentList.Add(s);
        }

        static Student takeInputForStudent()
        {
            Console.WriteLine("Enter name of student: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age of student: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FSC Marks of student: ");
            double fscMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter ECAT Marks of student: ");
            double ecatMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many preferences to enter: ");
            int option = int.Parse(Console.ReadLine());
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            for (int x = 0; x < option; x++)
            {
                Console.WriteLine("Enter preference");
                //preferences[x].;
            }
            Student student = new Student(name, age, fscMarks, ecatMarks);
            return student;
        }
        static Subject AddSubject()
        {
            Console.WriteLine("Enter subject code: ");
            string code = Console.ReadLine();
            Console.WriteLine("Enter subject type: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Credit Hours of subject: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fees of Subject: ");
            int subjectFees = int.Parse(Console.ReadLine());
            Subject subject = new Subject(code, type, creditHours, subjectFees);
            return subject;
        }
        static DegreeProgram takeInputForDegree()
        {
            Console.WriteLine("Enter degree Name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter degree duration: ");
            float degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of seats in degree: ");
            int seats = int.Parse(Console.ReadLine());
            DegreeProgram degree = new DegreeProgram(degreeName, degreeDuration, seats);
            return degree;
        }

        static int menu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View Registered Students");
            Console.WriteLine("5.View Student of a specific program");
            Console.WriteLine("6.Register subjects for a specific student");
            Console.WriteLine("7.Calculate Fees");
            Console.WriteLine("8.Exit");
            Console.Write("Enter your required option's number: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        
        static void clearScreen()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
