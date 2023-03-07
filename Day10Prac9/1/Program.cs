
interface Ix
{
    void IxF0(double параметр);
    void IxF1();
}

interface Iy
{
    void F0(double параметр);
    void F1();
}

interface Iz
{
    void F0(double параметр);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    public double w;

    public void F0(double w)
    {
        Console.WriteLine("Результат неявной реализации метода F0: " + 15 / w);
    }

    public void F1()
    {
        Console.WriteLine("Результат неявной реализации метода F1");
    }

    public void IxF0(double w)
    {
        Console.WriteLine("Результат неявной реализации метода IxF0: " + (2 * w - 3));
    }

    public void IxF1()
    {
        Console.WriteLine("Результат неявной реализации метода IxF1");
    }

   
    void Iz.F0(double w)
    {
        Console.WriteLine("Результат явной реализации метода F0: " + (Math.Pow(w,2) - w));
    }

    void Iz.F1()
    {
        Console.WriteLine("Результат явной реализации метода F1");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestClass obj = new TestClass();
        
        obj.w = 453.0;

        Ix objIx = obj;
        objIx.IxF0(obj.w);
        objIx.IxF1();

        Iy objIy = obj;
        objIy.F0(obj.w);
        objIy.F1();

        Iz objIz = obj;
        objIz.F0(obj.w);
        objIz.F1();

        
        IxF0((double)obj.w);
    }

    
    static void IxF0(double параметр)
    {
        TestClass obj = new TestClass();
        Ix objIx = obj;
        objIx.IxF0(параметр);
    }
}