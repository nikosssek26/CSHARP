using System;
public class Kata{
    public static int PositiveSum(int[] arr){ int sum = 0;
        foreach (int i in arr){
            if (i > 0) { 
                sum += i;
            }
        }return sum;
    }
}