static void Sin(int x)
{
    Console.WriteLine($"Выражение равно = { x* Math.Sin(x)}");
    Thread.Sleep(1000);
}
Console.Write("Введите х:");
int x = int.Parse(Console.ReadLine());
Parallel.For(0, 10, Sin);