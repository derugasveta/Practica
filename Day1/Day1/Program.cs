using System;

namespace pz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double a2 = double.Parse(Console.ReadLine());
            double d = a2 / a1;
            Console.Write("Ответ =  {0:##.###}", d);
        }
    }
}