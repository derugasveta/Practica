using System;

namespace pz1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            if (x >= 0.1 && x <= 1.5)
            {
                double z = Math.Log10(Math.Pow(Math.E, 2) + 4) - 2 * x;
            }
            else if (x > 1.5)
            {
                double z = Math.Pow(x, 2) - 1;
            }
            double z1 = (Math.Pow(x, 2)) - ((Math.Sqrt(1 - Math.Pow(Math.Sin(x), 2) / Math.Cos(2 * Math.PI) / 3) * Math.Pow(Math.E, 4 * Math.Sqrt(x))));
            Console.WriteLine($"Ответ функции z1: {z1}");

        }
    }
}