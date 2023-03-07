using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class ConsoleUI
    {
         public static void Show(Airplane airplane)
        {
            Console.WriteLine($"{airplane.DestinationName} {airplane.FlightNumber}  {airplane.DepartureTime.ToShortTimeString()}");
        }
        public static void Show(List<Airplane> airplanes)
        {
            foreach (var airplane in airplanes)
            {
                Show(airplane);
            }
        }
    }
}
