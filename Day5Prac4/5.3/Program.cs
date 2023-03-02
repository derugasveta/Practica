using System;
namespace _5._1
{
    class Programm
    {
        static void Swap(ref double x, ref double y)
        {
            double c = x;
            x = y;
            y = c;



        }
        static void Main()
        {
            try
            {
                Console.Write("Введите a:");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Изменение  a и b");
                Swap(ref a, ref b);
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine();
                Console.Write("Enter c:");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Enter d:");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Изменение с и d ");
                Swap(ref c, ref d);
                Console.WriteLine("c = " + c);
                Console.WriteLine("d = " + d);
                Console.WriteLine("Изменение b и с");
                Swap(ref b, ref c);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);
            }
            catch (FormatException error)
            {
                Console.WriteLine("Ошибка" + error.Message);

            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Ошибка" + error.Message);
            }
        }

    }
}

