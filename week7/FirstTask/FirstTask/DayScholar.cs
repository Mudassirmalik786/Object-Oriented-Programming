using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class DayScholar : Student
    {
        public string pickUpPoint;
        public string BusNo;
        public string pickUpDistance;

        public int getBusFee()
        {
            int fee = 0;
            fee = 5000;
            return fee;
        }
    }
}
