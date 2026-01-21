using System;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        foreach (char c in str.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }
}
