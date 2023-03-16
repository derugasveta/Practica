using System;
using System.Collections;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = @"..\..\..\..\txt1.txt";

        Console.WriteLine("Введите значения a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значения b:");
        int b = int.Parse(Console.ReadLine());
        string[] input =path.Split(' ');

        StreamReader reader = new StreamReader(path);
        Queue interval = new Queue();
        Queue lessA = new Queue();
        Queue moreB = new Queue();
        while (!reader.EndOfStream)
        {
            int num = int.Parse(reader.ReadLine());
            if (num >= a && num <= b)
            {
               
                interval.Enqueue(num);
            }
            else if (num < a)
            {
               
                lessA.Enqueue(num);
            }
            else if (num > b)
            {
                moreB.Enqueue(num);
            }
        }
        reader.Close();

        Console.WriteLine("Числа в интервале [a, b]:");
        while (interval.Count > 0)
        {
            Console.Write(interval.Dequeue() + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Числа меньше a:");
        while (lessA.Count > 0)
        {
            Console.Write(lessA.Dequeue() + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Числа больше b:");
        while (moreB.Count > 0)
        {
            Console.Write(moreB.Dequeue() + " ");
        }
        Console.WriteLine();
    }
}
