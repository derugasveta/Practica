using System;

namespace pz1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите номер масти: ");
            string m = Console.ReadLine();

            switch (m)
            {
                case "1":
                    Console.WriteLine("Пики");
                    break;
                case "2":
                    Console.WriteLine("Трефы");
                    break;

                case "3":
                    Console.WriteLine("Бубны");
                    break;
                case "4":
                    Console.WriteLine("Червы");
                    break;

                default:
                    Console.WriteLine("Такой масти нет");
                    break;
            }



        }
    }
}