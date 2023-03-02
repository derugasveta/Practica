using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Triangle
    {
        public double _firstSide { get; set; }
        public double _secondSide { get; set; }

        public double _thirdSide { get; set; }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }
        //поменять метод 
        public double FindSquare(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide == secondSide || secondSide == thirdSide || firstSide == thirdSide)
            {
                Console.WriteLine("Треугольник равнобедренный ");
                return (firstSide * secondSide) / 2;
            }
            else if (firstSide == secondSide && firstSide == thirdSide)
            {
                Console.WriteLine("Треугольник равносторонний");
                return (Math.Sqrt(3) * Math.Pow(firstSide, 2)) / 4;
            }
            else if (firstSide != secondSide && secondSide != thirdSide && firstSide != thirdSide)
            {
                Console.WriteLine("Треугольник разносторонний");
                return 1 / 2 * firstSide * secondSide * thirdSide;
            }
            else if (firstSide == 90 || secondSide == 90 || thirdSide == 90)
            {
                Console.WriteLine("Прямоугольный треугольник");
                return (firstSide * secondSide) / 2;
            }

            return (0.5) * (firstSide * secondSide * thirdSide);


        }
        public double FindPerimeter(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }
        public double FindIntersectionPointOfMedians(double firstSide, double secondSide, double thirdSide)
        {
            double a = Math.Sqrt(2 * Math.Pow(firstSide, 2) + 2 * Math.Pow(secondSide, 2) - 2 * Math.Pow(thirdSide, 2)) / 2;
            return a;
        }
    }
}
