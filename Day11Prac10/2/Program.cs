using _2;
Console.Write("Введите а: ");
double a1 = double.Parse(Console.ReadLine());
Console.Write("Введите b: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите d: ");
double d1 = double.Parse(Console.ReadLine());
A a = new A();
A b = new A();
B d = new B(a1,b1,d1);

Console.WriteLine($"Сумма: {d.c2}");