
using _1;
Console.Write("Enter phone model: ");
string model = Console.ReadLine();
Console.Write("Enter the number of phone functions: ");
int numOfFunc = int.Parse(Console.ReadLine());
CellularTelephone phone = new CellularTelephone(model,numOfFunc);
Console.WriteLine(phone);
Console.WriteLine($"Cost {phone.Cost():F2}");



