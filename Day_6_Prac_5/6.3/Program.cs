using System.Diagnostics.Metrics;
using System;
using System.Security.Cryptography.X509Certificates;

Console.Write("Enter how many columns and rows will be in the matrix: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

if (n <=10)
{
    Console.WriteLine("Enter the matrix fill range");
    Console.WriteLine("Enter a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter b: ");
    int b = int.Parse(Console.ReadLine());
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = random.Next(a, b);
        }

    }

    for (int x= 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {

            Console.Write(" " + matrix[x,y]);
        }
        Console.WriteLine();

    }

    
    Console.WriteLine("Enter h: ");
    int h = int.Parse(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < h)
            {
                count++;
            }
            
        }
       
    }
    Console.WriteLine($"Number of numbers less than {h} =  {count}");
    Console.WriteLine();
    Console.Write("Enter column number:");
    int colum = int.Parse(Console.ReadLine());
    int counte1 = 0;

    if (colum >= 0 && colum<=n)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            if (matrix[i, colum] % 2 != 0)
            {
                counte1++;

            }
        }
            Console.WriteLine($"Number of odd column elements {colum} = {counte1}");
        
       
        


    }

    else
    {
        Console.WriteLine("No such column");
    }

}
else
{
    Console.WriteLine("You entered a number greater than 10, restart the program");
}