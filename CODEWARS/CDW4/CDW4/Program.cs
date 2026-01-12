public class Kata
{
    public static string MouthSize(string animal)
    {
        if (animal == null)
            return "";
        if (animal.ToLower() == "alligator")
            return "small";
        else
            return "wide";
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Kata.MouthSize("alligator");
    }
}