
using _1;



MyList<int> myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
myList.Add(3);
myList.Add(4);

Console.WriteLine("Array:");
for (int i = 0; i < myList.Count; i++)
{
    Console.Write(myList[i] + " ");
}

Console.WriteLine("\nEnter index elementa, that you interested");
int index = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Element at index {index} - {myList[index]} " );
Console.WriteLine($"Count element {myList.Count}");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Challenge a static method: ");
WriteArray(MyList<int>.GetArray(myList));


void WriteArray<T>(T[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}



