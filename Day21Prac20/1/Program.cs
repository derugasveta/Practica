// 
using System.Threading.Tasks;

void ReverseNumber(int number)
{
    int thousands, thousands2, hundreds, hundreds2, dozens, dozens2, units;

    dozens = 1;
    if ((number > 10) && (number < 1000) && (dozens != 0))
    {
        Console.WriteLine("Введите другое число");
    }
    else
    {
        thousands = number / 1000;
        thousands2 = number % 1000;
        hundreds = thousands2 / 100;
        hundreds2 = thousands2 % 100;
        dozens = hundreds2 / 10;
        dozens2 = hundreds2 % 10;
        units = dozens2 % 10;

        Console.WriteLine($"{units}  {dozens}  {hundreds}  {thousands}");
    }

}
Console.Write("Введите четырехзначное  число:");
int number = int.Parse(Console.ReadLine());
var task = Task<int>.Run(() => ReverseNumber(number));
Thread.Sleep(1000);

Task task1 = new Task(() => ReverseNumber(number));
task1.Start();
Thread.Sleep(1000);

Task task2 = Task.Factory.StartNew(() => ReverseNumber(number));
Thread.Sleep(1000);
while (!task1.IsCompleted)
{
    Thread.Sleep(2000);
    Console.WriteLine("Wait...");
    Console.Clear();
}

