using System;

namespace pz1
{
    class Program
    {


        static void Main(string[] args)
        {
            double b = 3 * (Math.PI);
            int a = 0;
            int m = 10;


            Console.Write("Введите  X : ");
            double x = int.Parse(Console.ReadLine());
            double h = b - a / m;
            for (double i = a; i <= b; i += 0.1)
            {
                Console.WriteLine(x * Math.Sin(x));
                x += h;
            }
            double y = x * Math.Sin(x);
            Console.WriteLine(y);


        }
    }
}