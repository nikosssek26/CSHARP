using System;
using System.Linq;

public class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a == null || b == null) return false;

        if (a.Length != b.Length) return false;

        var sortedA = a.Select(x => x * x).OrderBy(x => x).ToArray();
        var sortedB = b.OrderBy(x => x).ToArray();

        for (int i = 0; i < sortedA.Length; i++)
        {
            if (sortedA[i] != sortedB[i]) return false;
        }

        return true;
    }
}

public class Program
{
    public static void Main()
    {
        int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
        int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
        bool result = AreTheySame.comp(a, b);
        Console.WriteLine(result); 
    }
}