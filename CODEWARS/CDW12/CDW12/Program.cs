using System;
using System.Linq;

public class Number
{
    public static int DigitalRoot(long n)
    {
        while (n > 9)
        {
            n = n.ToString().Select(ch => ch - '0').Sum();
        }

        Console.WriteLine(n);
        return (int)n;
    }
}
public class Program
{
    public static void Main()
    {
        Number.DigitalRoot(16);
        Number.DigitalRoot(942);
        Number.DigitalRoot(132189);
        Number.DigitalRoot(999999999999);
    }
}