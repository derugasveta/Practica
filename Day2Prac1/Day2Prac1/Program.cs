using System;

namespace pz1
{
    class Program
    {
        static void F(int a, int b)
        {
            Console.WriteLine("Вывод через For");
            Console.WriteLine("Целые четные числа: ");
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }


            }
        }
        static void W(int a, int b)
        {


            Console.WriteLine();
            Console.WriteLine("Вывод через While");
            Console.WriteLine("Целые четные числа: ");
            int x = 1;
            while (x <= b)
            {
                if (x % 2 == 0)
                {
                    Console.Write(x + " ");
                }
                x++;

            }
        }
        static void D(int a, int b)
        {
            Console.WriteLine();
            Console.WriteLine("Вывод через do While");
            Console.WriteLine("Целые числа");
            int s = 1;
            do
            {
                if (s % 2 == 0)
                {
                    Console.Write(s + " ");
                }

                s++;
            } while (s < b);

        }

        static void Main(string[] args)
        {

            Console.Write("Введите  число с которого начинается диапазон: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите  число с которого заканчивается диапазон: ");
            int b = int.Parse(Console.ReadLine());

            F(a, b);
            D(a, b);
            W(a, b);






        }
    }
}// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
