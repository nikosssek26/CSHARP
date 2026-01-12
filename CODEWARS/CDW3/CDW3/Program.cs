public class DecTools
{
    public static int Digits(ulong n)
    {
        if (n == 0) return 1;

        int count = 0;
        while (n > 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ulong number = 1234567890;
        int digitCount = DecTools.Digits(number);
        System.Console.WriteLine($"The number {number} has {digitCount} digits.");
    }
}


