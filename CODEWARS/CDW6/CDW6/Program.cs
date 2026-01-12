using System;

public class Kata
{
    public static string GetMiddle(string s)
    {
        if (string.IsNullOrEmpty(s))
            throw new ArgumentNullException(nameof(s), "It must be a complete string");

        int len = s.Length;
        if (len == 1)
            return s;

        if (len % 2 == 0)
        {
            int start = len / 2 - 1;
            return s.Substring(start, 2);
        }
        else
        {
            int start = len / 2;
            return s.Substring(start, 1);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.GetMiddle("middle"));
    }
}