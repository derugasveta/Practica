using System.Collections.Generic;
Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());

Task[] tasks1 = new Task[2]
{
new Task(() =>Console.WriteLine( ResultFuncZ1(a, 2000))),

new Task(() => Console.WriteLine(  ResultFuncZ2(a,5000)))
};
foreach (var t in tasks1)
t.Start();
Task.WaitAny(tasks1);
Console.WriteLine("First");
Task.WaitAll(tasks1);
Console.WriteLine("End");

double ResultFuncZ2(double a,int milliseconds)
{

    Thread.Sleep(milliseconds);
    Console.WriteLine(Thread.CurrentThread.Name);
    return 4 - Math.Pow(a, 2) / 2;
}

double ResultFuncZ1(double a,int milliseconds)
{
    Thread.Sleep(milliseconds);
    Console.WriteLine(Thread.CurrentThread.Name);
    return Math.Pow(((1 + a + Math.Pow(a, 2)) / ((2 * a) + Math.Pow(a, 2))) * (5 - 2 * Math.Pow(a, 2)),-1);
}