using System;
using System.Diagnostics;
using z1.Providers;

namespace z1
{
    struct Marsh
    {
        public string StartingPoint;

        public string Destination;

        public int RouteNumber;

        public Marsh(String StartingPoint, String Destination, int RouteNumber)
        {
          this.StartingPoint = StartingPoint;
          this.Destination = Destination;
          this.RouteNumber = RouteNumber;
        }
        public string WriteMarsh()
        {
            return $"Номер маршрута {RouteNumber}\nНачальный пункт маршрута:{StartingPoint}\nКонечный пункт маршрута:{Destination}";
        }
    }
    class Program
    {
        static void Main()
        {

          var marsh1 = new Marsh(Faker.Address.City(), Faker.Address.City(), new Random().Next(1, 100));
          var marshrutes=MemoryMarshProvider.GetMarshes();
            Console.WriteLine("Введите  номер  маршрута: ");
         
            int number = int.Parse(Console.ReadLine());

            bool hasMarshrutes=false;
            foreach (var marsh in marshrutes)
            {
                if (marsh.RouteNumber==number)
                {
                    Console.WriteLine(marsh.WriteMarsh());
                    hasMarshrutes=true;
                }
            }

            if (hasMarshrutes==false)
            {
                Console.WriteLine("Такого маршрута нет");
            }

           

        }
    }
}
