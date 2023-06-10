using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Hostellite : Student
    {
        public string rollNo;
        public bool isFridgeAvailable;
        public bool isInternetAvailable;

        public int getHostelFee()
        {
            int fee = 0;
            fee = 1000;
            return fee;
        }
    }
}
