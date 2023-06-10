using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Student
    {
        public string name;
        public string session;
        public bool isDayScholar;
        public float entryTestMarks;
        public float hsMarks;

        public double calculateMerit()
        {
            double merit = 0.0;
            merit = ((entryTestMarks * 30) / 400F) + ((hsMarks * 70) / 1100);
            return merit;
        }
    }
}
