using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class MyPoint
    {
        public int x;
        public int y;
        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void ShowX()   
        {
            Console.Write("this is point: " + x);
        }
        public void ShowY()
        {
            Console.Write("this is point: " + y);
        }

        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double distanceWithCords(int x, int y)
        {
            double distance;
            distance = Math.Sqrt(((this.x - x) * (this.x - x)) + ((this.y - y) * (this.y - y)));
            return distance;
        }
        public double distanceWithObject(MyPoint another)
        {
            int xDiff = this.x - another.x;
            int yDiff = this.y - another.y;
            double distance = Math.Sqrt(xDiff*xDiff + yDiff*yDiff);
            return distance;
        }
        public static double distanceFromZero(int x, int y)
        {
            double distance = Math.Sqrt(((x - 0) * (x - 0)) + ((y - 0) * (y - 0)));
            return distance;
        }

        public static implicit operator int(MyPoint v)
        {
            throw new NotImplementedException();
        }
    }
}
