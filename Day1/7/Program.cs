using System;


namespace pz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());

            double z1 = (a + 2 / Math.Sqrt(2 * a)) - (a / Math.Sqrt(2 * a) + 2) + (2 / a - Math.Sqrt(2 * a));
            double z2 = 1 / Math.Sqrt(a) + Math.Sqrt(2);
            Console.WriteLine($"Ответ функции z1: {z1}");
            Console.WriteLine($"Ответ функции z2: {z2}");

        }
    }
}