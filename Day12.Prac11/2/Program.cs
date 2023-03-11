using _2;
using System.Linq;

var random = new Random();
List<PrintedProducts> products = new List<PrintedProducts>();

for (int i = 0; i < 6; i++)
{
    var number = random.Next(0, 2);
    if (number == 0)
    {
        Magazine magazine = CreateMagazin();
        products.Add(magazine);
    }
    else
    {
        Newspaper newspaper = CreateNewspaper();
        products.Add(newspaper);
    }
}


var TotalCost = 0M;
foreach (var product in products)
{
    TotalCost += product.Cost();

}
var totalCostNewspaper = 0M;
var count = 0M;
var count1 = 0M;
var totalCostMagazin = 0M;
foreach (var product in products)
{
    if (product is Newspaper newspaper)
    {
        totalCostNewspaper += newspaper.Cost();
        count += totalCostNewspaper;
    }
    else if (product is Magazine magazine)
    {
        totalCostMagazin += magazine.Cost();
        count1 += totalCostMagazin;
    }

}
Console.WriteLine($"средняя сумма стоимость журналов {count}");
Console.WriteLine($"средняя сумма стоимость газет {count1}");
Newspaper CreateNewspaper()
{
    Console.Write("\nВведите название газеты: ");
    var name = Console.ReadLine();
    Console.Write("Введите количество страниц: ");
    var numberOfSheets = int.Parse(Console.ReadLine());
    Console.Write("Введите стоимость одной страницы: ");
    decimal costPerSheet = decimal.Parse(Console.ReadLine());
    Console.Write("Введите тираж: ");
    int circulation = int.Parse(Console.ReadLine());

    return new Newspaper(numberOfSheets, costPerSheet, circulation, name);
}

Magazine CreateMagazin()
{
    Console.Write("\nВведите название журнала: ");
    var name = Console.ReadLine();
    Console.Write("Введите цену: ");
    decimal cost = decimal.Parse(Console.ReadLine());
    Console.Write("Введите тираж: ");
    int circulation = int.Parse(Console.ReadLine());
    return new Magazine(circulation, cost, name);
}

