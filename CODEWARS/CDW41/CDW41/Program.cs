using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input)
    {
        if(input.Contains('x') || input.Contains('X') || input.Contains('o') || input.Contains('O'))
        {
            var xCount = input.Count(c => c == 'x' || c == 'X');
            var oCount = input.Count(c => c == 'o' || c == 'O');
            return xCount == oCount;
        }
        else if (input == "")
            return true;
        else
            return false;
    }
}