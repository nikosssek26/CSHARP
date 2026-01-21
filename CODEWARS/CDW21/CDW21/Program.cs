using System;

public static class Kata{
    public static int TrailingZeros(int n){
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be non-negative.");

        int zeros = 0;
        for (long p = 5; p <= n; p *= 5)
        {
            zeros += (int)(n / p);
        }

        return zeros;
    }
}