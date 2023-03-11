
using _1;



MyList<int> myList = new MyList<int>();

var numberToAdd = 5;
var numberToRemove = 6;
var index = 2;
int[] array = {1, 2, 3};
foreach (var arr in array)
{

    Console.Write(arr + " ");

}
Console.WriteLine();
Console.WriteLine("New array:");

myList.Add(numberToAdd);
foreach (var arr in array)
{

    Console.Write(arr + " ");

}
Console.WriteLine(numberToAdd);






//var wasNumberRemoved=numbers.Remove(numberToRemove);
//if (wasNumberRemoved)
//{
//    Console.WriteLine(numbers);

//}

//Console.WriteLine();
//Console.WriteLine(numbers[index]);
