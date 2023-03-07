using _2;
using _2.AirplainsComparers;

Airport airport = new Airport(Provider.GetAiroplants());
var airplanes = airport.Airplanes;
Console.WriteLine("Полная информация о самолетах :");
ConsoleUI.Show(airplanes);
Console.WriteLine();
Console.WriteLine("Выберите сортировку: \n1.По пунктам назначения.\n2.По номеру рейса.\n3.По времени.");
int sort = int.Parse(Console.ReadLine());
switch (sort)
{
    case 1:

        Console.WriteLine("Информация посел сортировки по  пунктам назначения ");
        airplanes.Sort();
        ConsoleUI.Show(airplanes);
        break;
    case 2:
        Console.WriteLine("Информация после сорировки по номеру рейса");

        airplanes.Sort(new AirplainDepartureTimeComparer());
        ConsoleUI.Show(airplanes);
        break;
    case 3:
        Console.WriteLine("Информация после сортироваки по времемени");
        airplanes.Sort((f, s) => f.DestinationName.CompareTo(s.DestinationName));
        ConsoleUI.Show(airplanes);
        break;

    default:
        break;
}
//1
//2
//3

Console.WriteLine();

Console.WriteLine("Введите пункт назначения");
string destinationName = Console.ReadLine();

Console.WriteLine("Введите номер рейса");
int flightNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите время оправления");
TimeOnly departureTime = TimeOnly.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Добавления рейса");
var airplain = new Airplane(destinationName, flightNumber, departureTime);
airport.Add(airplain);
ConsoleUI.Show(airplanes);

Console.WriteLine();

Console.WriteLine("Введите номер рейса самолета, о котором хотите знать информацию: ");

int num = int.Parse(Console.ReadLine());

var foundedAirplan = airplanes.Where(a => a.FlightNumber == num).ToList();
if (foundedAirplan != null)
{
    ConsoleUI.Show(foundedAirplan);
}
else
{

    Console.WriteLine("Самолета с таким рейсом не существует");
}
Console.WriteLine("Введите время отправления самолета, о котором хотите знать информацию: ");


var time = TimeOnly.Parse(Console.ReadLine());

var foundedAirplan2 = airplanes.Where(a => a.DepartureTime == time).ToList();
if (foundedAirplan2 != null)
{
    ConsoleUI.Show(foundedAirplan2);
}
else
{

    Console.WriteLine("Самолета с таким рейсом не существует");
}