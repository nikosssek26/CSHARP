using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        var count = 0;
        foreach (bool sheep in sheeps)
        {
            if(sheep == true)
                count++;
        }
        return count;
    }
}