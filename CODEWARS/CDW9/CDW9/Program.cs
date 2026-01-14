using System;
using System.Linq;
using System.Collections.Generic;

public class MorseCodeDecoder
{
    public static string Decode(string morseCode)
    {
        string[] words = morseCode.Trim().Split(new[] { "   " }, StringSplitOptions.None);

        IEnumerable<string> decodedWords = words.Select(word =>
        {
            string[] characters = word.Split(' ');

            string decodedChars = string.Concat(characters.Select(c => MorseCode.Get(c)));

            return decodedChars;
        });

        return string.Join(" ", decodedWords);
    }
}

public class Program
{
    public static void Main()
    {
        string morseCode = ".... . -.--   .--- ..- -.. .";
        string decodedMessage = MorseCodeDecoder.Decode(morseCode);
        Console.WriteLine(decodedMessage);
    }
}