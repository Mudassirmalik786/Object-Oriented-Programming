using Challenge1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint myPoint = new MyPoint();
            int option;
            do
            {
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    makeLine();
                }
                else if (option == 2)
                {
                    int x = updateBegin(myPoint);
                }
                else if (option == 3)
                {
                    int y = updateEnd(myPoint);
                }
                else if (option == 4)
                {
                    showBegin();
                }
                else if (option == 5)
                {
                    showEnd();
                }
                else if (option == 6)
                {
                    calculateLength();
                }
                else if (option == 7)
                {
                    calculateGradient();
                }
                else if (option == 8)
                {
                    distanceOfBeginFromZero();
                }
                else if (option == 9)
                {
                    distanceOfEndFromZero();
                }

            } while (option != 10);
        }

        static void distanceOfBeginFromZero()
        {
            int x, y;
            Console.Write("Enter Begin point 1 to get distance: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter Begin point 2 to get distance: ");
            y = int.Parse(Console.ReadLine());
            double distance = MyPoint.distanceFromZero(x, y);
            Console.Write("The distance from zero is: " + distance);
        }
        static void distanceOfEndFromZero()
        {
            int x, y;
            Console.Write("Enter End point 1 to get distance: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter End point 2 to get distance: ");
            y = int.Parse(Console.ReadLine());
            double distance = MyPoint.distanceFromZero(x, y);
            Console.Write("The distance from zero is: " + distance);
        }
        static void calculateLength()
        {
            int x, y;
            Console.Write("Enter point 1 to get length: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter point 2 to get length: ");
            y = int.Parse(Console.ReadLine());
            double get = MyLine.GetLength(x, y);
            Console.Write("The length of these points is: " + get);
        }

        static void calculateGradient()
        {
            MyLine myLine = new MyLine();
            double distance = myLine.getGradient();
            Console.WriteLine("Gradient is: " + distance);
        }
        static void showEnd()
        {
            MyPoint myPoint = new MyPoint();
            myPoint.ShowY();
        }
        static void showBegin()
        {
            MyPoint myPoint = new MyPoint();
            myPoint.ShowX();
        }
        static int updateEnd(MyPoint myPoint)
        {
            Console.Write("Enter the update end point: ");
            int y = int.Parse(Console.ReadLine());
            myPoint.setY(y);
            Console.WriteLine("The point has been updated!!!");
            return y;
        }
        static int updateBegin(MyPoint myPoint)
        {
            Console.Write("Enter the update begin point: ");
            int x = int.Parse(Console.ReadLine());
            myPoint.setX(x);
            Console.WriteLine("The point has been updated!!!");
            return x;
        }
        static void makeLine()
        {
            int x, y;
            Console.Write("Enter 1st point: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd point: ");
            y = int.Parse(Console.ReadLine());
            MyPoint myPoint = new MyPoint(x, y);
        }
        static void header()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("                TAKING LINE               ");
            Console.WriteLine("******************************************");
        }
        static int menu()
        {
            header();
            Console.WriteLine("1.Make a line");
            Console.WriteLine("2.Update the begin point");
            Console.WriteLine("3.Update the end point");
            Console.WriteLine("4.Show the begin point");
            Console.WriteLine("5.Show the end point");
            Console.WriteLine("6.Get the length of line");
            Console.WriteLine("7.Get the gradient of line");
            Console.WriteLine("8.Find the distance of begin point from zero coordinates");
            Console.WriteLine("9.Find the distance of end point from zero coordinates");
            Console.WriteLine("10.Exit");
            Console.Write("Enter your desired option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
