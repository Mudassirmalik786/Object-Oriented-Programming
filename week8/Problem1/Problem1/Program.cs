using Problem1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder();
            Cylinder c1 = new Cylinder(2, 3);
            Cylinder c2 = new Cylinder(3, 4, "Red");
            double volume = c.getVolume();
            double volume1 = c1.getVolume();
            double volume2 = c2.getVolume();
            Console.WriteLine(volume + " " + volume1 + " " + volume2);
            Console.ReadKey();
        }
    }
}
