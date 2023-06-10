using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    class Circle
    {
        protected double radius;
        protected string color;
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            double area;
            area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public string toString()
        {
            string convert = "";
            convert = "Circle " + "[ radius = " + radius + ", color = " + color + "]";
            return convert;
        }
    }
}
