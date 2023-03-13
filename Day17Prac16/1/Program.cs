FileStream file = new FileStream(@"D:f.txt", FileMode.Open);
StreamReader reader = new StreamReader(file);
string s;
int n = 0;
while ((s = reader.ReadLine()) != null)
{
    n++;
}
reader.Close();
int[] mas = new int[n];
int sum = 0;
FileStream file1 = new FileStream(@"f.txt", FileMode.Open);
StreamReader reader1 = new StreamReader(file1);
for (int i = 0; i < n; i++)
{
    mas[i] = Convert.ToInt32(reader1.ReadLine());
    sum += mas[i];
}
int razn = mas[0] - mas[mas.Length - 1];
Console.WriteLine("Сумма компонент файла- {0}\nРазнсоть первой и последней компонент - { 1} ",sum,razn);
Console.ReadLine();