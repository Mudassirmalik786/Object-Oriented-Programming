using Problem2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Mudassir", "Lahore", "BSCS", 2023, 2003);
            Student student1 = new Student("Asad", "Lahore", "BSCS", 2023, 4000);
            Staff staff = new Staff("Touseef", "Chiniot", "High School", 30000);
            Staff staff1 = new Staff("HAmza", "Lahore", "High School", 40000);

            List<Person> persons = new List<Person>() {student,  student , staff , staff1};
            foreach(Person p in persons)
            {
                Console.WriteLine(p.toString());
            }
            Console.ReadKey();
        }
    }
}
