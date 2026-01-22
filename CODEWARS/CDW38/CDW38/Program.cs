public class Kata{
    public static string AreYouPlayingBanjo(string name){
        if (name.StartsWith("R") || name.StartsWith("r"))
            return name + " plays banjo";
        else
            return name + " does not play banjo";
    }
}