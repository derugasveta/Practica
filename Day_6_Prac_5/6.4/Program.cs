using System.Diagnostics.Metrics;
using System;
using System.Security.Cryptography.X509Certificates;
using _6._4;

Console.Write("Enter how many columns and rows will be in the matrix: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

Random random = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        matrix[i, j] = random.Next(10);
    }

}

for (int x = 0; x < matrix.GetLength(0); x++)
{
    for (int y = 0; y < matrix.GetLength(1); y++)
    {

        Console.Write(" " + matrix[x, y]);
    }
    Console.WriteLine();

}

Console.WriteLine("Enter the line number, the amount you want to know");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the column number, the amount you want to know");
int col = int.Parse(Console.ReadLine());
if (row >= 0 && row <= n || col >= 0 && col < n)
{
    int sumRow = matrix.CalcRow(row);
    int sumCol = matrix.CalcCol(col);
    int max = Math.Max(sumRow, sumCol);
    Console.WriteLine($"Sum of numbers in a row {row} = {sumRow}");
    Console.WriteLine($"Sum of numbers in a column {col} = {sumCol}");
    if (max == sumRow)
    {
        Console.WriteLine($"The maximum of two numbers is the sum of the numbers in the string {row} ");
    }
    else
    {
        Console.WriteLine($"The maximum of two numbers is the sum of the numbers in the column {col} ");
    }
}
else
{
    Console.WriteLine("No such column and row ");
}
