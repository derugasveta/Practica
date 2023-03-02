using System;
namespace _4_1
{
    class Programm
    {
        static double F(double number)
        {
            if (number % 2 ==0)
            {
                return number = 0;
            }
            else { return number / 2; }
        }
        static void Main()
        {
            Console.Write("Enter number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(F(number));
        }
    }
}