using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{

    class Truck
    {
        private Ladder l1;
        private HosePipe h1;
        private FireFighter f1;

        public Truck(HosePipe h1, FireFighter f1)
        {
            l1 = new Ladder(34F, "Black");
            this.h1 = h1;
            this.f1 = f1;
        }
    }
}
