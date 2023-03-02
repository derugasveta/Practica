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
                Console.WriteLine("Фамиля владельца: " + cars[i]._ownerName); 
                Console.WriteLine("Госномер: " + cars[i]._numberPlate);
                Console.WriteLine("Цвет: " + cars[i]._color);
                Console.WriteLine("Присутствие на стоянке: " + cars[i]._presence);
            }
        }
        public void Find()
        {
            Console.WriteLine("Выберите способ поиска");
            Console.WriteLine("1.Поиск по фамилии\n2.Поиск по госномерe\n3.Поиск по цвету");           
            int a1 = int.Parse(Console.ReadLine());
            switch (a1)
            {
                case 1:
                    Console.WriteLine("Введите фамилию");
                    string fi = Console.ReadLine();
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i]._ownerName == fi)
                        {
                            Console.WriteLine($"Машина на стоянке" + "\nНомер авто - " + cars[i]._numberPlate + "\nЦвет авто - " + cars[i]._color + "\nФамилия владельца - " + cars[i]._ownerName);
                        }
                        else  
                        {
                            Console.WriteLine("Машина на стоянке отсутствует");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите номер авто");
                    int num = int.Parse(Console.ReadLine());
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i]._numberPlate == num)
                        {
                            Console.WriteLine("Машина на стоянке " + "\nНомер авто - " + cars[i]._numberPlate + "\nЦвет авто - " + cars[i]._color + "\nФамилия владельца - " + cars[i]._ownerName);
                        }
                        else
                        {
                            Console.WriteLine("Машина на стоянке отсутствует");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите цвет авто");
                    string col = Console.ReadLine();
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i]._color == col)
                        {
                            Console.WriteLine("Машина на стоянке " + "\nНомер авто - " + cars[i]._numberPlate + "\nЦвет авто - " + cars[i]._color + "\nФамилия владельца - " + cars[i]._ownerName);
                        }
                        else
                        {
                            Console.WriteLine("Машина на стоянке отсутствует");
                        }
                    }
                    break;
            }

        }
        public void Add()
        {
            Console.WriteLine("Введите фамилию владельца"); 
            string n = Console.ReadLine();
            Console.WriteLine("Введите госномер");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цвет машины");
            string y = Console.ReadLine();
            Console.WriteLine("Присутствует машина на праковке?");
            string u = Console.ReadLine();
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = new Car(a, y, n, u);
        }

    }
}
