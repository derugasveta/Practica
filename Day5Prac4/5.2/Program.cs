
try
{
    Console.Write("Введите х:");
    double x = double.Parse(Console.ReadLine());

    if (x > -4 && x <= -1)
    {
        double z = x / 2 * x + 2;
        Console.WriteLine($"Ответ уравнения : {z}");
    }
    else if (x > -1)
    {
        double z = x + 3;
        Console.WriteLine($"Ответ уравнения : {z}");
    }
    else throw new Exception("Ошибка выхода из диапозона допустимых значений х");
}

catch (FormatException error)
{
    Console.WriteLine("Ошибка" + error.Message);

}
catch (DivideByZeroException error)
{
    Console.WriteLine("Ошибка" + error.Message);
}