
Console.Write("Введите число:");
int number  = int.Parse(Console.ReadLine());  
Task <int> task1 = new Task<int>(() => MulNumber(number));
Task task2 = task1.ContinueWith(task=>Print(task.Result));
task1.Start();
task2.Wait();
static int MulNumber(int number)
{
    int  hundreds, hundreds2, dozens, dozens2, units;
    int mul = 1;
    dozens = 1;
    if ((number > 10) && (number < 100) && (dozens != 0))
    {
        Console.WriteLine("Введите другое число");
    }
    else
    {
        hundreds = number / 100;
        hundreds2 = number % 100;
        dozens = hundreds2 / 10;
        dozens2 = hundreds2 % 10;
        units = dozens2 % 10;
        mul = units * dozens * hundreds;
        Console.WriteLine($"Произведение цифр число {number} = {mul}  ");
    }

    return mul;
}

static void Print(int mulNumber)
{
    Console.WriteLine($"Произведение: {mulNumber}");
}