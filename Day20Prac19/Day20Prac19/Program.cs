using System;
namespace _4_3
{
    class Programm
    {/// <summary>
        /// Метод F , который находит функцию y
        ///</summary>

        static double F(double x)
        {
            double y;
            /// <summary>
            /// С помощью оператор ветвления if else мы пишем решение функцию, при каких-то значениях
            /// </summary>
            if (x + 2 < 1)
            {
                return y = Math.Pow(x, 2);
            }
            else if (x + 2 >= 1 && x + 2 < 10)
            {
                return y = 1 / (x + 2);
            }
            else
            {
                return y = x + 2;
            }

        }
        /// <summary>
        /// Метод F с перегрузкой 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void F(double x, out double y)
        {

            y = 0;
            if ((x + 2) < 1) y = Math.Pow(x, 2);
            else if ((x + 2) < 10) y = 1 / (x + 2);
            else y = x + 2;

        }
            ///<summary>
            ///Метод main точка входа.
            /// </summary>
        static void Main()
        {///<summary>
            ///Объявленение переменных 
            /// </summary>
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Первая перегрузка");
            ///<summary>
            ///Цикл For, который начинается с а и заканчиввается, когда i будет равна b,  а также имеет шаг h
            ///и выводит на экран рещультат при использовании метода F
            /// </summary>

            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine("F({0:F2}) = {1:F4}", i, F(i));
            }
            Console.WriteLine("Вторая перегрузка");
            ///<summary>
            ///Цикл For, который начинается с а и заканчиввается, когда i будет равна b,  а также имеет шаг h
            ///и выводит на экран рещультат при использовании метода F с перегрузкой 
            /// </summary>
            for (double i = a; i <= b; i += h)
            {
                F(i, out double y);
                Console.WriteLine("F({0:F2}) = {1:F4}", i, y);
            }
        }
    }
}