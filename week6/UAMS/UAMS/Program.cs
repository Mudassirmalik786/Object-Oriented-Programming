using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
using UAMS.UI;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string subjectPath = "E:\\OOP\\week6\\UAMS\\subject.txt";
            string degreePath = "E:\\OOP\\week6\\UAMS\\degree.txt";
            string studentPath = "E:\\OOP\\week6\\UAMS\\student.txt";
            if (SubjectDL.readfromFile(subjectPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
            }
            if (DegreeProgramDL.readFromFile(degreePath))
            {
                Console.WriteLine("DegreeProgram Data Loaded Successfully");
            }
            if (StudentDL.readfromFile(studentPath))
            {
                Console.WriteLine("Student Data Loaded Successfully");
            }
            int option;
            do
            {
                option = MenuUI.Menu();
                MenuUI.clearScreen();
                if (option == 1)
                {
                    if (DegreeProgramDL.programList.Count > 0)
                    {
                        //  Add Student
                        Student s = StudentUI.takeInputForStudent();
                        StudentDL.addIntoStudentList(s);
                        StudentDL.storeIntoFile(studentPath, s);
                    }
                }
                else if (option == 2)
                {
                    // Add Degree Program
                    DegreeProgram d = DegreeProgramUI.takeInputForDegree();
                    DegreeProgramDL.addIntoDegreeList(d);
                    DegreeProgramDL.storeIntoFile(degreePath, d);
                }
                else if (option == 3)
                {
                    //Generate Merit
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = StudentDL.sortStudentsByMerit();
                    StudentDL.giveAdmission(sortedStudentList);
                    StudentUI.printStudents();
                }
                else if (option == 4)
                {
                    // View Registered Students
                    StudentUI.viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    // View Registred Student of a specific Program
                    string degName;
                    Console.Write("Etner Degree Name: ");
                    degName = Console.ReadLine();
                    StudentUI.viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    // Registered Subjects For Specific Student 
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentDL.StudentPresent(name);
                    if (s != null)
                    {
                        SubjectUI.viewSubjects(s);
                        SubjectUI.registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    // Calculate Fees For All Registered Students
                    StudentUI.calculateFeeForAll();
                }
            }
            while (option != 8); //Exit
            Console.ReadLine();
        }
    }
}
