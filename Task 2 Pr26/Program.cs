using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Pr26
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Print();
            Console.WriteLine();

            Point point2 = new Point(4.6, 6.4);
            point2.Print();
            Console.WriteLine();

            Point point3 = new Point(6.4, 9.4);
            point3.Print();
            Console.WriteLine();

            Console.WriteLine($"Количество точек: {Point.Count}");
            Console.ReadLine();
        }
    }
}
