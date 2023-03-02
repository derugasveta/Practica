try
{
    Console.Write("Enter x: ");
    double x = double.Parse(Console.ReadLine());
    double y = 2 * x / Math.Sin(x) - 4 * x;
    double z = 1 / Math.Pow(Math.Tan(x - 1), 2);
    Console.WriteLine("y = " + y);
    Console.WriteLine("z = " + z);
}
catch (FormatException error)
{
    Console.WriteLine(error.Message);

}
catch (DivideByZeroException error)
{
    Console.WriteLine(error.Message);
}

