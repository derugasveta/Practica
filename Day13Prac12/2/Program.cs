﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr9
{
    delegate int Func(int a, int b);
    class Program
    {
        static void Main()
        {

            Func<int, int, int> f = (a, b) => a + b;
            Func g = (a, b) => a - b;
            Func h = (a, b) => a * b;
            Func i = (a, b) => a / b;
            Console.WriteLine("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию: \n1.Add \n2.Sub \n3.Mul\n4.Div");
            string c = Console.ReadLine();

            switch (c)
            {
                case "1":
                    Console.WriteLine($"Выражение равно: {f(a, b)}");
                    break;
                case "2":
                    Console.WriteLine($"Выражение равно: {g(a, b)}");
                    break;
                case "3":
                    Console.WriteLine($"Выражение равно: {h(a, b)}");
                    break;
                case "4":
                    Console.WriteLine($"Выражение равно: {i(a, b)}");
                    if (b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя, перезапустите программу");

                    }
                    break;
                default:
                    Console.WriteLine("Такой операции нет");
                    break;

            }



        }


    }
}
