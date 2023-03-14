
using _2;

MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

myDictionary.Add(0, "Obj 1");
myDictionary.Add(1, "Obj 2");
myDictionary.Add(2, "Obj 3");

for (int i = 0; i < myDictionary.Count; i++)
{
    Console.WriteLine(myDictionary[i]);
}

Console.WriteLine("\nEnter index elementa, that you interested");
int index = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Element at index {index} - {myDictionary[index]} ");

Console.WriteLine($"Size myDictionary {myDictionary.Count}");