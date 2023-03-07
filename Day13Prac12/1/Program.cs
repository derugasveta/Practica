
Console.Write("Enter r: ");
int r = Convert.ToInt32(Console.ReadLine());
CalcFigure cf = GetLength;
cf += GetArea;
cf += GetVolume;
Console.WriteLine($"Result of delegate execution: {cf(r):F2}");

static double GetLength(double r)
{
    Console.WriteLine("Circumference: ");
  return  2 * Math.PI * r;
}
static double GetArea(double r)
{
    Console.WriteLine("Area of a circle:");
    return Math.PI* r *r;
}
static double GetVolume(double r)
{
    Console.WriteLine("Ball volume:");
   return 4 / 3 * Math.PI * r * r * r;
}
delegate double CalcFigure(double r);
