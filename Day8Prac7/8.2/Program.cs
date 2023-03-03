using System.Text.RegularExpressions;

Console.Write("Enter text: ");
string text = Console.ReadLine();
var result = Regex.Matches(text, @"[\b.!?]*Информатика").Count;
Console.WriteLine(result);
