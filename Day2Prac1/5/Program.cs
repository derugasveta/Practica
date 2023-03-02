using System;

namespace pz1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите угол стороны a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите угол стороны b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите угол стороны c: ");
            int c = int.Parse(Console.ReadLine());
            int s = a + b + c;
            if (s != 180)
            {
                Console.WriteLine("Сумма сторон не равна 180 - это не треугольник");
            }
            else
            {

                if (a == 90 || b == 90 || c == 90)
                {
                    Console.WriteLine($"Треугольник со {a} {b} {c} сторонами прямоугольный"); ;
                }

                else
                {
                    Console.WriteLine("Треугольник непрямоугольный");
                }
            }

        }
    }
}