using System;
public class Kata{
    public static int[] SortNumbers(int[] nums){
        if (nums == null || nums.Length == 0)
            return Array.Empty<int>();
        int[] copy = (int[])nums.Clone();
        Array.Sort(copy);
        return copy;
    }
}