using System;

namespace z4
{
    class Program
    {
        static void Main(string[] args)
        {
            int thousands, thousands2, hundreds, hundreds2, dozens, dozens2, units, N;
            Console.Write("Введите четырехзначное  число:");
            N = int.Parse(Console.ReadLine());
            dozens = 1;
            if ((N > 10) && (N < 1000) && (dozens != 0))
            {
                Console.WriteLine("Введите другое число");
            }
            else
            {
                thousands = N / 1000;
                thousands2 = N % 1000;
                hundreds = thousands2 / 100;
                hundreds2 = thousands2 % 100;
                dozens = hundreds2 / 10;
                dozens2 = hundreds2 % 10;
                units = dozens2 % 10;

                Console.WriteLine($"Числа наоборот: {units} {dozens} {hundreds} {thousands}");
            }



        }
    }
}

