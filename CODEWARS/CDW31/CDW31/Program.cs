public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        int result = 1;
        foreach (int number in numbers){
            result += number * number;
        }
        return result - 1;
    }
}