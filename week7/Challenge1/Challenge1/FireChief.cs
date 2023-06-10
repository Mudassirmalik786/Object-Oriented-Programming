using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class FireChief : FireFighter
    {
        public FireChief(string name) : base(name)
        {
        }
        public void SelectFighter(string fighterName)
        {
            Console.WriteLine("Tell " + fighterName + " Fire fighter to extinguish fire ");
        }
    }
}
