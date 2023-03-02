using System;

namespace pz1
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.Write("Введите  число - цена за 1 кг  : ");
            double a = int.Parse(Console.ReadLine());
            double tmp;

            for (double i = 0.1; i <= 1.0; i += 0.1)
            {
                tmp = i * a;

                Console.WriteLine($"Цена = " + tmp);

            }





        }
    }
}