using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Parking
    {
        Car[] cars;
        public Parking()
        {
            int length = 0;
            cars = new Car[length];
        }
        public void Print()
        {

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Фамиля владельца: " + cars[i].OwnerName);
                Console.WriteLine("Госномер: " + cars[i].NumberPlate);
                Console.WriteLine("Цвет: " + cars[i].Color);
                Console.WriteLine("Присутствие на стоянке: " + cars[i].Presence);
            }
        }
        public void FindByLastName(string ownerName)
        {


            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].OwnerName == ownerName)
                {
                    Console.WriteLine($"Машина на стоянке" + "\nНомер авто - " + cars[i].NumberPlate + "\nЦвет авто - " + cars[i].Color + "\nФамилия владельца - " + cars[i].OwnerName);
                }
                else
                {
                    Console.WriteLine("Машина на стоянке отсутствует");
                }
            }
        }
        public void FindByNumber(int numberPlate)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].NumberPlate == numberPlate)
                {
                    Console.WriteLine("Машина на стоянке " + "\nНомер авто - " + cars[i].NumberPlate + "\nЦвет авто - " + cars[i].Color + "\nФамилия владельца - " + cars[i].OwnerName);
                }
                else
                {
                    Console.WriteLine("Машина на стоянке отсутствует");
                }
            }
        }
        public void FindByColor(string color)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Color == color)
                {
                    Console.WriteLine("Машина на стоянке " + "\nНомер авто - " + cars[i].NumberPlate + "\nЦвет авто - " + cars[i].Color + "\nФамилия владельца - " + cars[i].OwnerName);
                }
                else
                {
                    Console.WriteLine("Машина на стоянке отсутствует");
                }
            }

        }
        public IReadOnlyList<Car> FindBy(Predicate<Car> filter)
        {
            var findCars = new List<Car>();
            foreach (var car in cars)
            {
                if (filter(car))
                {
                    findCars.Add(car);
                }
            }
            return findCars;
        }
        public void Add(string n, int a, string y, string u)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = new Car(a, y, n, u);
        }

    }
}
