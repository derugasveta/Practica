using System;


namespace pz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус:");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Введите высота цилиндра: ");
            double h = double.Parse(Console.ReadLine());
            double v = Math.PI * Math.Pow(r, 2) * h;
            Console.Write("Объем цилиндра = {0:##.###}", v);
        }
    }
}
