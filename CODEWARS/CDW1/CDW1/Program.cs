using System;
using System.Linq;
public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Expected 10 int in an array");
        foreach (var num in numbers)
        {
            if (num < 0 || num > 9)
                throw new ArgumentException("Each number must me in 0-9 range");
        }
        string digits = string.Concat(numbers.Select(n => n.ToString()));
        string area = digits.Substring(0, 3);
        string rest = digits.Substring(3, 3);
        string last = digits.Substring(6, 4);

        return $"({area}) {rest}-{last}";
    }

}
// Example usage
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        string phoneNumber = Kata.CreatePhoneNumber(numbers);
        Console.WriteLine(phoneNumber);
    }
}