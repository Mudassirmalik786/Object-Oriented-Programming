using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask1.BL
{
    class Student
    {
        public string name;
        public int rollNo;
        public int ecatMarks;
        public Student(string name, int rollNo, int ecatMarks)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.ecatMarks = ecatMarks;
        }
    }
}
