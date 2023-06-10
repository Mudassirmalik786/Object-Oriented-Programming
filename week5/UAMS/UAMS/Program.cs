using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS
{
    class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<DegreeProgram> programList = new List<DegreeProgram>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = Menu();
                clearScreen();
                if(option == 1)
                {
                    if(programList.Count > 0)
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
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = sortStudentsByMerit();
                    giveAdmission(sortedStudentList);
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
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name);
                    if(s != null)
                    {
                        viewSubjects(s);
                        registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    calculateFeeForAll();
                }
                clearScreen();
            } while (option != 8);
        }
        static Student StudentPresent(string name)
        {
            foreach(Student s in studentList)
            {
                if(name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        static void calculateFeeForAll()
        {
            foreach(Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " has " + s.calculateFee() + " fees ");
                }
            }
        }
        static void registerSubjects(Student s)
        {
            Console.WriteLine("Enter how many subjects you want to register");
            int count = int.Parse(Console.ReadLine());
            for(int x = 0; x < count; x++)
            {
                Console.Write("Enter the subject Code: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(Subject sub in s.regDegree.subjects)
                {
                    if(code == sub.code && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Enter valid Course");
                    x--;
                }
            }
        }
        static List<Student> sortStudentsByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach(Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach(Student s in sortedStudentList)
            {
                foreach(DegreeProgram d in s.preferences)
                {
                    if(d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        static void printStudents()
        {
            foreach(Student s in studentList)
            {
                if(s.regDegree != null)
                {
                    Console.WriteLine(s.name + "got Admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + "did not get Admission");
                }
            }
        }
        static void viewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach(Student s in studentList)
            {
                if(s.regDegree != null)
                {
                    if(degName == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age );
                    }
                }
            }
        }
        static void viewRegisteredStudents()
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }
            }
        }
        static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }
        static DegreeProgram takeInputForDegree()
        { 
            float degreeDuration;
            int seats;
            Console.Write("Enter Degree NAme: ");
            string degreeName = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats For Degree: ");
            seats = int.Parse(Console.ReadLine());

            DegreeProgram degProg = new DegreeProgram(degreeName, degreeDuration, seats);
            Console.WriteLine("Enter How many Subjects to Enter: ");
            int count = int.Parse(Console.ReadLine());
            for(int x = 0; x < count; x++)
            {
                degProg.AddSubjects(takeInputForSubject());
            }
            return degProg;
        }
        static Subject takeInputForSubject()
        {
            Console.Write("Enter subject Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter subject type: ");
            string type = Console.ReadLine();
            Console.Write("Enter subject Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter subject Fees");
            int subjectFees = int.Parse(Console.ReadLine());
            Subject sub = new Subject(code, type, creditHours, subjectFees);
            return sub;
        }
        static void addIntoStudentList(Student s)
        {
            studentList.Add(s);
        }
        static Student takeInputForStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter student FSC Marks: ");
            double fscMarks = double.Parse(Console.ReadLine());
            Console.Write("Enter subject Fees");
            double ecatMarks = double.Parse(Console.ReadLine());
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            Console.WriteLine("Available degree Programs");
            viewDegreePrograms();
            Console.WriteLine("Enter how many Preferences to Enter");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                string degName = Console.ReadLine();
                bool flag = false;
                foreach (DegreeProgram dp in programList)
                {
                    if (degName == dp.degreeName && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter valid Degree Program Name");
                    x--;
                }
            }
            Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
            return s;
        }
        static void viewDegreePrograms()
        {
            foreach(DegreeProgram dp in programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
        static void header()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("                 UAMS                       ");
            Console.WriteLine("********************************************");
        }
        static void viewSubjects(Student s)
        {
            if(s.regDegree != null)
            {
                Console.WriteLine("Sub Code\tSub Type");
                foreach(Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }
            }
        }
        static int Menu()
        {
            header();
            int option;
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View Registered Students");
            Console.WriteLine("5.View Students of a specific Program");
            Console.WriteLine("6.Registered Subjects Foe a specific Program");
            Console.WriteLine("7.Calculate Fees for all Registered Students");
            Console.WriteLine("8.Exit");
            Console.Write("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void clearScreen()
        {
            Console.WriteLine("Press any key to contionue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
