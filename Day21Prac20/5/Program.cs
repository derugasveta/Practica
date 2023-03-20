using System.Collections.Generic;
using System.Runtime.CompilerServices;

void Sum(int n, ParallelLoopState pls)
{
    int result = 0;
    for (int i = 0; i <= n; i++)
    {
        if (result >= 10)

        {
            Console.WriteLine($"Сумма = {result}");
            pls.Break();
            break;
        }
        result += i;
    }
  
}
void Mul(int n, ParallelLoopState pls)
{
    int result = 1;
    for (int i = 1; i < n; i++)
    {
        if (result >= 10)
        { 
    Console.WriteLine($"Произведение = {result}");
            pls.Break();
            break;
        }
        result *= i;
    }
}


ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 65, 2, 6, 87 }, Sum);
ParallelLoopResult result2 = Parallel.ForEach<int>(new List<int>() { 65, 2, 6, 87 }, Mul);
if (!result.IsCompleted)
    Console.WriteLine($"Выполнение цикла завершено на итерации {result.LowestBreakIteration}");


