using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class MyLine
    {
        private MyPoint begin;
        private MyPoint end;
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public MyLine()
        {
        }
        public MyPoint getBegin()
        {
            return begin;
        }
        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }
        public MyPoint getEnd()
        {
            return end;
        }
        public void setEnd(MyPoint end)
        { 
            this.end = end;
        }
        public static double GetLength(int x ,int y)
        {
            MyPoint myPoint = new MyPoint(x, y);
            double distance;
            distance = myPoint.distanceWithObject(myPoint);
            return distance;
        }
        public double getGradient()
        {
            int yDiff = end.y - begin.y;
            int xDiff = begin.x - end.x;
            double distance = Math.Atan2(yDiff, xDiff);
            return distance;
        }
    }
}
