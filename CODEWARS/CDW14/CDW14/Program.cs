public class Kata
{
    public static string removeBMW(string text)
    {
        if(text == string.Empty && text == null) return null;
        foreach (var item in text)
        {
            if(item == 'B' || item == 'M' || item == 'W' || item == 'b' || item == 'w' || item == 'm')
            {
                text = text.Replace(item.ToString(), "");
            }
        }
        return text;
    }
}
public class Program
{
    public static void Main()
    {
        string text = "This is a BMW car. bmw is popular.";
        string result = Kata.removeBMW(text);
        System.Console.WriteLine(result);
    }
}