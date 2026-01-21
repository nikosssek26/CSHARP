public class Kata
{
    public static string AbbrevName(string name)
    {
        string result = "";
        foreach (char c in name){
            if(c==' ')
                result = name[0] + "." + name[name.IndexOf(c)+1];
            }
        return result.ToUpper();
    }
}