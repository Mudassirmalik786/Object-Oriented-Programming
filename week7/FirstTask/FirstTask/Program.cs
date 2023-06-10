using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DayScholar std = new DayScholar();
            std.name = "Ahmad";
            std.BusNo = "1";
            Console.WriteLine(std.name + "is Allocated Bus " + std.BusNo);
            Console.ReadKey();
        }
    }
}
