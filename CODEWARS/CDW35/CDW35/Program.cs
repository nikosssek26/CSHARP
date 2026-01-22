public class Kata
{
    public static bool Solution(string str, string ending)
    {
        if (str == null || ending == null)
            return false;
        return str.EndsWith(ending);
    }
}