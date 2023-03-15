using System.Text;

var pathFileTORead = @"..\..\..\..\txt2.txt";
string file = File.ReadAllText(pathFileTORead, Encoding.UTF8);
Console.Write("File:" + file);
int sum = 0;
for (int i = 0; i < file.Length; i++)
{
    sum += i;
}
Console.Write("Sum: " + sum);