namespace CSP5
{
    internal class Program
    {
        private static string statystykaliter(string s)
        {
            string wynik = string.Empty;
            SortedDictionary<char, int> litery = new SortedDictionary<char, int>();
            foreach (char c in s)
            {
                if (litery.ContainsKey(c)) litery[c]++;
                else litery.Add(c, 1);
            }
            foreach (var e in litery)
            {
                wynik += $"{e.Key}:{e.Value}\n";
            }
            return  wynik;
        }

        static void Main(string[] args)
        {
            string s = string.Empty;
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                s += (char)r.Next('a', 'z' +1);
            }
            Console.WriteLine(s);
            Console.WriteLine(statystykaliter(s));
        }
    }
}