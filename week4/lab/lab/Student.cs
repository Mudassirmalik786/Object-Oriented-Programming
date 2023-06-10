using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Student
    {
        public string name;
        public int rollNumber;
        public float cGPA;
        public int matricMarks;
        public int fscMarks;
        public int ecatMarks;
        public string hometown;
        public bool isHostelite;
        public bool isTakingScholarship;
        
        public Student(string name, int rollNumber, float cGPA, int matricMarks, int fscMarks, int ecatMarks, string hometown)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.cGPA = cGPA;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.hometown = hometown;
        }
        public Student()
        {

        }
        public float calculateMerit()
        {
            float calculate = ((fscMarks * 60) / 100);
            float calculate1 = ((ecatMarks * 40) / 100);
            float merit = calculate + calculate1;
            return merit;
        }
        public bool isEligibleforScholarship(float merit)
        {
            if(merit > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
