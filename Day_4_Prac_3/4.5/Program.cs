using _4._5;
namespace _4._5
{
    class Program
    {
        static void Main()
        {
            Parking car = new Parking();
            Console.WriteLine("Добавление машины");
            Console.WriteLine();
            car.Add();
            Console.WriteLine();
            car.Add();
           
            Console.WriteLine();
            Console.WriteLine("Выбрать пункт:");
            Console.WriteLine();
            Console.WriteLine("1.Поиск машины на стоянке");
         
            Console.WriteLine("2.Список машин "); 
            int a = int.Parse(Console.ReadLine());
            if (a != 0 && a <= 3)
            {
                switch (a)
                {
                    case 1:
                        car.Find();
                        break;
                  
                    case 2:
                        car.Print();
                        break;
                    
                }
            }
            else
                Console.WriteLine("Такого пункта нет");
        }
    }
} 

        