Console.Write("Enter string: ");
string text = new string(Console.ReadLine());

string[] words = text.Split();

var maxLength = FindMaxLength(words);
PrintWords(words, maxLength);



static void PrintWords(string[] words, int maxLength)
{
    Console.WriteLine("Word with maximum length:");
    int index = 1;
    foreach (var word in words)
    {
        if (word.Length == maxLength)
        {
            Console.WriteLine($"{index++}. {word}");
        }
    }
}

static int FindMaxLength(string[] words)
{
    var maxLength = 0;
    foreach (var word in words)
    {
        if (word.Length > maxLength)
        {
            maxLength = word.Length;
        }
    }
    return maxLength;
}