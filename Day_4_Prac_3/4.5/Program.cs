using _4._5;
namespace _4._5
{
    class Program
    {
        static void Main()
        {
            Parking parking = new Parking();

            Console.WriteLine("Добавление машины");
            Console.WriteLine("Введите фамилию владельца");
            string n = Console.ReadLine();
            Console.WriteLine("Введите госномер");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цвет машины");
            string y = Console.ReadLine();
            Console.WriteLine("Присутствует машина на праковке?");
            string u = Console.ReadLine();

            Console.WriteLine();
            parking.Add(n,a,y,u);
            Console.WriteLine();
            parking.Add(n,a,y,u);

            Console.WriteLine("Выберите способ поиска");
            Console.WriteLine("1.Поиск по фамилии\n2.Поиск по госномерe\n3.Поиск по цвету");
            int a1 = int.Parse(Console.ReadLine());
            switch (a1)
            {
                case 1:
                    Console.WriteLine("Введите фамилию");
                    string fi = Console.ReadLine();
                    parking.FindByLastName(fi);
                    break;
                case 2:
                    Console.WriteLine("Введите номер авто");
                    int num = int.Parse(Console.ReadLine());
                    parking.FindByNumber(num);
                    break;
                case 3:
                    Console.WriteLine("Введите цвет авто");
                    string col = Console.ReadLine();
                    parking.FindByColor(col);
                    break;
                default:
                    Console.WriteLine("Такого пунта нет");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Выбрать пункт:");
            Console.WriteLine();
       
            Console.WriteLine("2.Список машин ");
            int l = int.Parse(Console.ReadLine());
            if (a != 0 && a <= 3)
            {  parking.Print();                    
            }
            else
                Console.WriteLine("Такого пункта нет");

            var lastName = "Name";
            var foundedCarsByLastName = parking.FindBy(car => car.OwnerName == lastName);

            var color = "Red";
            var carsColor = parking.FindBy(car => car.Color == color);


        }

    }
}

