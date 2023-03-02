Console.Write("Enter string: ");
string text = new string(Console.ReadLine());
string[] words = text.Split();
Console.Write("Enter n - the number that must not exceed the letters in the word: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Words with number of sides less than or equal: ");
foreach (var word in words)
{
	if (word.Length <= n)
	{
		Console.WriteLine(word );
	}
}


