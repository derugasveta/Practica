using System.Threading;
static void FirstThread()
{

    for (int i = 0; i < 10; i++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(i);
        Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(10);
    }

}
static void SecondThread()
{

    for (int i = 10; i < 20; i++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(i);
        Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(10);
    }

}
static void ThirdThread()
{
    for (int i = 20; i < 30; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(i);
        Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(10);
    }

}
Thread thread = new Thread(FirstThread);
Thread thread1 = new Thread(SecondThread);
Thread thread2 = new Thread(ThirdThread);

thread.Priority = ThreadPriority.Highest;
thread1.Priority = ThreadPriority.Normal;
thread2.Priority = ThreadPriority.Lowest;

thread.Start();
//thread.Join();

thread1.Start();
//thread1.Join();

thread2.Start();
//thread2.Join();