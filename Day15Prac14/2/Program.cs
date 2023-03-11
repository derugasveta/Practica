﻿using System.Threading;
using System.Diagnostics;
object locker = new object();
void Sum()
{
    lock (locker)
    {
        Console.WriteLine(Thread.CurrentThread.Name);
        int sum = 0;
        for (int i = 1; i < 11; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
        Thread.Sleep(10);
    }
}
Stopwatch sw = new Stopwatch();
Thread thread = new Thread(Sum);
thread.Name = "Thread";
//Console.WriteLine("Поток 1 ");

Thread thread1 = new Thread(Sum);
thread1.Name = "Thread 1";
//Console.WriteLine("Поток 2");
sw.Start();
thread.Start();
sw.Stop();
Console.WriteLine("Миллисекунды 1: "+sw.ElapsedMilliseconds.ToString());
sw.Stop();
thread1.Start();
sw.Stop();
Console.WriteLine("Миллисекунды 2: "+sw.ElapsedMilliseconds.ToString());
