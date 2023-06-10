using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class student
    {
        public student()
        {
            Console.WriteLine("Default Constructor Called");
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class studentTaskThree
    {
        public studentTaskThree()
        {
            sname = "Jill";
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class studentTaskFour
    {
        public studentTaskFour()
        {
            sname = "Jill";
            matricMarks = 100.0F;
            fscMarks = 101.0F;
            ecatMarks = 400.0F;
            aggregate = 86.0F;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class studentTaskFive
    {
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class studentTaskSix
    {
        public studentTaskSix(string n)
        {
            sname = n;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class studentTaskSeven
    {
        public studentTaskSeven(string n, float a, float b, float c, float d)
        {
            sname = n;
            matricMarks = a;
            fscMarks = b;
            ecatMarks = c;
            aggregate = d;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class studentTaskNine
    {
        public studentTaskNine(studentTaskNine s)
        {
            sname = s.sname;
            matricMarks = s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.fscMarks;
            aggregate = s.aggregate;
        }
        public studentTaskNine()
        {
            Console.WriteLine("Default Constructor");
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
    class clockType
    {
        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int h)
        {
            hours = h;
        }
        public clockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public clockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public clockType(int h,int m,int s,int totalHours,int totalMinutes,int totalSeconds)
        {
            if (totalHours > h)
            {
                hours = totalHours - h;
            }
            if (totalMinutes > m)
            {
                minutes = totalMinutes - m;
            }
            if (totalSeconds > s)
            {
                seconds = totalSeconds - s;
            }
        }
        public void incrementSecond()
        {
            seconds++;
        }
        public void incrementhours()
        {
            hours++;
        }
        public void incrementminutes()
        {
            minutes++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
        public bool isEqual(int h,int m, int s)
        {
            if(hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clockType temp)
        {
            if(hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public clockType(clockType c)//This copy cunstructor adds because in program.cs file different objects can be created
        {
            hours = c.hours;
            minutes = c.minutes;
            seconds = c.seconds;
        }
        public int hours;
        public int minutes;
        public int seconds;
    }
}
