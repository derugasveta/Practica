Console.Write("Enter string: ");
string str = Console.ReadLine();


WorkerString ws = ToLower;
ws += ToUpper;
ws += Replace;

Console.WriteLine($"\r\nExecution result: {ws(str)}");


static string ToUpper(string str) => str.ToUpper();
static string ToLower(string str) => str.ToLower();
static string Replace(string str) => str.Replace("а","о");

delegate string WorkerString(string str);