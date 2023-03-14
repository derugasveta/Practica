string file = File.ReadAllText("D:\\с#\\кпияп\\практика по с#\\Practica\\Day17Prac16\\txt.txt");
Console.WriteLine(file);
int sum = 0;
for (int i = 0; i < file.Length+1; i++)
{
    sum += i;
}
Console.WriteLine(sum);