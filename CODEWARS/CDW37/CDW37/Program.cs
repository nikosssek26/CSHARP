public class Kata{
    public static string FindNeedle(object[] haystack){
        for(int i = 0; i < haystack.Length; i++){
            if(haystack[i] is string str && str == "needle")
                return "found the needle at position " + i;
        }
        return "didnt find the needle";
    }
}