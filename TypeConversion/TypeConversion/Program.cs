namespace TypeConversion;

class Program
{
    static void Main(string[] args)
    {

        byte b = 1;
        int i = b;
        Console.WriteLine(i);

        int a = 1;
        byte c = (byte) a;
        Console.WriteLine(c);
    }
}

