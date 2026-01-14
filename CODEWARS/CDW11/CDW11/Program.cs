using System;

public static class KataChallenge{
    public static bool IsDivisible(int x, params int[] divisors){
        if (divisors == null || divisors.Length == 0) return false;
        foreach (var d in divisors){
            if (d == 0) return false;
            if (x % d != 0) return false;
        }

        return true;
    }
    public static bool IsDivisible(int x, int y, int z) =>
        IsDivisible(x, new int[] { y, z });
    public static bool IsDivisible(int[] args){
        if (args == null || args.Length < 2) return false;
        int x = args[0];
        int[] divisors = new int[args.Length - 1];
        Array.Copy(args, 1, divisors, 0, divisors.Length);
        return IsDivisible(x, divisors);
    }
}