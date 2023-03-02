using System;

Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Response of the equation = " + Factorial(Factorial(n) + 2 ) / Factorial(n));


int Factorial(int num)
{
    if (num == 0)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}