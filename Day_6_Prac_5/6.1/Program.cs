Console.Write("Enter the number of elements in the array: ");
int num = int.Parse(Console.ReadLine());
double[] array = new double[num];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter array elements at index {i}: ") ;
    array[i] = double.Parse(Console.ReadLine());
}
double max = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
   
}
Console.Write($"Max elements index: {IndexOf(array,max)} ");
static double IndexOf(double [] arr, double value)

{
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] == value)
        {
            return i;   
        }
    }
    return -1;

}
