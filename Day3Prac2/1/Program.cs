using System;

using _3._1;

namespace _3
{


    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Введите число a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b: ");
            double b = double.Parse(Console.ReadLine());

            A a1 = new A(a, b);
            A a2 = new A(a, b);
            Console.WriteLine("Возведение в куб = " + a1.Erection(a, b));
            Console.WriteLine("Вычисление = " + a2.Calculation(a, b));



        }
    }
}