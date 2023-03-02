Console.Write("Enter matrix size: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter element at index: {i} -  ");
    array[i] = int.Parse(Console.ReadLine());
    
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write( array[i] + " ");
   
}
Console.WriteLine();
for (int i = 0; i < array.Length-1; i++)
{
    if (array[i] > 0 && array[i + 1] < 0 || array[i] < 0 && array[i + 1] > 0)
    {
        
        Console.Write(array[i] + " ");
        if (i==array.Length-2)
        {
            Console.Write(array[i+1]);

        }
    }
    else
    {
        
        array[i] = -array[i];
        Console.Write( array[i] + " ");
        if (i == array.Length - 2)
        {
            Console.Write(-array[i + 1]);

        }
    }
    
}

