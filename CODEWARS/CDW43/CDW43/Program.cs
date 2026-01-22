public class Kata{
    public static int FindShort(string s){
        var words = s.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
        int minLen = int.MaxValue;

        foreach (var word in words)
            if (word.Length < minLen)
                minLen = word.Length;

        return minLen == int.MaxValue ? 0 : minLen;
    }
}