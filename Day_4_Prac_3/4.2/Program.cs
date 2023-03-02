using System;
namespace _4_2
{
    class Programm
    {
        static double F(double x)
        {
            double y;
            if (x + 2 < 1)
            {
                return y = Math.Pow(x, 2);
            }
            else if (x + 2 >= 1 && x + 2 < 10)
            {
                return y = 1 / ( x + 2);
            }
            else
            {
                return y = x + 2;
            }

        }
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine("F({0:F2}) = {1:F4}", i, F(i));
            }
        }

           
    }
}