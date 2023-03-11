using System.ComponentModel.Design;

Console.Write("Enter side equilateral triangle: ");
double side = double.Parse(Console.ReadLine());
TrianglCalc tc = SideWithdrawal;
tc += Square;
tc+=Perimeter;
Console.WriteLine($"Result of delegate execution: {tc(side)}");

const int three = 3;
static double Perimeter(double side)
{
    return side * three;
}
static double Square(double side)
{
    double height = Math.Sqrt(3) / 3 * side;
    return 0.5 * side * height;
}
static double SideWithdrawal(double side)
{
    return side;
}
delegate double TrianglCalc(double side);