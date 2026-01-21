using System;
using System.Linq;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        var list = numbers
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => long.Parse(s))
            .ToList();

        long max = list.Max();
        long min = list.Min();

        return $"{max} {min}";
    }
}