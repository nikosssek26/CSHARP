using System;

public class Kata
{
    public static int CountBits(int n)
    {
        string binary = Convert.ToString(n, 2);
        Console.WriteLine(binary);
        int count = 0;
        foreach (char c in binary)
        {
            if(c == '1')
                count++;
        }
        return count;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.CountBits(10));
    }
}