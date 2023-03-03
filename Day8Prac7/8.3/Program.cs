using System.Text.RegularExpressions;
string text = "Привет как дела привет как дела привет";
//Console.Write("Enter text: ");
//string text = Console.ReadLine();

Regex regex = new Regex(@".+[а-я]{2,}[ ]");
MatchCollection words = regex.Matches(text);

if (words.Count > 0)
{
    foreach (Match word in words)
    {
        Console.WriteLine(word.Value);
    }
}
else
{
    Console.WriteLine("No repeated words");
}