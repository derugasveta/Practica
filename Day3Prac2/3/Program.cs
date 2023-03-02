using _3._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длину стороны а: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину стороны b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину стороны c: ");
            double c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);
            Console.WriteLine("Периметр треугольника = " + triangle.FindPerimeter(a, b, c));
            Console.WriteLine();
            Console.WriteLine("Точка пересечения медиан = " + triangle.FindIntersectionPointOfMedians(a, b, c));
            Console.WriteLine();
            Console.WriteLine("Площадь = " + triangle.FindSquare(a, b, c));
        }
    }
}
