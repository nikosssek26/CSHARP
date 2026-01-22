using System.Text.RegularExpressions;
public class Kata{
    public static bool ValidatePin(string pin){
        return Regex.IsMatch(pin, @"\A(?:\d{4}|\d{6})\z");
    }
}