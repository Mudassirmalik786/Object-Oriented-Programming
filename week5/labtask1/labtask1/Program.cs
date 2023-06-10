using labtask1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //taskOne();
            taskOneA();
            Console.ReadKey();
        }
        static void taskOne()
        {
            List<string> stringList = new List<string>() { "Asad", "Mudassir", "Ahsan" };
            stringList.Sort();
            foreach (string i in stringList)
                Console.Write(i + " ");

            List<float> floatList = new List<float>() { 0.3F, 0.5F , 2.9F };
            floatList.Sort();
            foreach (float i in floatList)
                Console.WriteLine(i + " ");
        }
        static void taskOneA()
        {
            Student s1 = new Student("Mudassir", 32, 128);
            Student s2 = new Student("Asad", 11, 168);
            Student s3 = new Student("Hamza", 54, 167);
            List<Student> studentList = new List<Student>() { s1, s2, s3 };
            List<Student> sortedList = studentList.OrderBy(Student=> Student.rollNo).ToList();
            Console.WriteLine("Name \t Roll no \t Ecat Marks");
            foreach(Student s in sortedList)
            {
                Console.WriteLine("{0} \t {1} \t \t {2}", s.name, s.rollNo, s.ecatMarks);
            }
        }
    }
}
