using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class FireFighter
    {
        protected string name;
        
        public FireFighter(string name)
        {
            this.name = name;
        }
        public void driveTruck()
        {
            Console.WriteLine(name + " is driving truck ");
        }
        
        public void extinguishFire()
        {
            Console.WriteLine(name + " is extinguish fire ");
        }
    }
}
