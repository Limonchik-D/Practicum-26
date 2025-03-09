using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Pr26
{
    class Point
    {
        private double x; 
        private double y;
        private static int count; //Подсчет количества точек


        public Point()
        {
            x = 1.0;
            y = 1.0;
            count++;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            count++;
        }
        public static int Count
        {
            get
            {
                return count;
            }
        }
        static Point()
        {
            count = 0;
        }

        public double GetX()
        {
            return x;
        }
        public double SetX(double x)
        {
            return this.x = x;
        }
        public double GetY()
        {
            return y;
        }
        public double SetY(double y)
        {
            return this.y = y;
        }
        public void Print()
        {
            Console.WriteLine($"Точки Х: {x}, У = {y}");
        }
    }
}
