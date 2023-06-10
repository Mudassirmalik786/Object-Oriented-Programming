using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class HosePipe
    {
        private string made;
        private string shape;
        private float diameter;
        private float flowRate;
        public HosePipe(string made, string shape, float diameter, float flowRate)
        {
            this.made = made;
            this.shape = shape;
            this.diameter = diameter;
            this.flowRate = flowRate;
        }
    }
}
