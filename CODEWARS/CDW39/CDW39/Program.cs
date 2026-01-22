using System;
public class Sum{
    public int GetSum(int a, int b){
        if (a == b)
            return a;
        long min = Math.Min(a, b);
        long max = Math.Max(a, b);
        long count = max - min + 1;
        long total = (min + max) * count / 2;
        return (int)total;
    }
}