using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Bicycle
    {
        private int cadence;
        private int gear;
        private int speed;
        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void setCadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void setGear(int gear)
        {
            this.gear = gear;
        }
        public void applyBrake(int decrement)
        {
            decrement = speed--;
        }
        public void speedUp(int increament)
        {
            increament = speed++;
        }
    }
}
