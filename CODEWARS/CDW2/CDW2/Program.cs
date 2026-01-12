using System;
using System.Linq;

public class Kata
{
    public static string BandNameGenerator(string str)
    {
        if (str.StartsWith(str[0]) && str.EndsWith(str[0]))
        {
            return char.ToUpper(str[0]) + str.Substring(1) + str.Substring(1);
        }
        return "The " + char.ToUpper(str[0])+ str.Substring(1) ;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine(Kata.BandNameGenerator("alaska")); // "alaskaalaska"
        Console.WriteLine(Kata.BandNameGenerator("dolphin")); // "The Dolphin"
    }
}