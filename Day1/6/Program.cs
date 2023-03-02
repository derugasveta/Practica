using System;

namespace pz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundreds, hundreds2, dozens, dozens2, units, N;
            Console.Write("Введите трехзначное  число:");
            N = int.Parse(Console.ReadLine());
            dozens = 1;
            if ((N > 10) && (N < 100) && (dozens != 0))
            {
                Console.WriteLine("Введите другое число");
            }
            else
            {

                hundreds = N / 100;
                hundreds2 = N % 100;
                dozens = hundreds2 / 10;
                dozens2 = hundreds2 % 10;
                units = dozens2 % 10;
                double h = units * dozens * hundreds;
                Console.WriteLine($"Произведение чисел:{h} ");

            }



        }
    }
}

