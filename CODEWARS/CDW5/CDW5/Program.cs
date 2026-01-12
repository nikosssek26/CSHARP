public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        var numbers = new System.Collections.Generic.List<string>();
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                int pos = char.ToLower(c) - 'a' + 1;
                if (pos >= 1 && pos <= 26)
                {
                    numbers.Add(pos.ToString());
                }
            }
        }
        return string.Join(" ", numbers);
    }
}
public class Program
{
    public static void Main()
    {
        string input = "The sunset sets at twelve o' clock.";
        string result = Kata.AlphabetPosition(input);
        System.Console.WriteLine(result);
    }
}
