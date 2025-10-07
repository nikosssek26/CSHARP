namespace CS1
{
    class Ulamek
    {
        public int licznik { set; get; }
        private int _mianownik;
        private bool czyPoprawny = true;

        public int mianownik
        {
            get
            {
                return _mianownik;
            }
            set
            {
                if (value == 0)
                    czyPoprawny = false;
                else
                    _mianownik = value;
            }
        }

        public double wartoscDziesietna
        {
            get { return (double)licznik / mianownik; }
        }

        public Ulamek(int licznik = 0, int mianownik = 1)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public override string ToString()
        {
            return czyPoprawny ? $"{licznik}/{mianownik}" : "błędny ułamek";
        }
        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            if (u1.mianownik != u2.mianownik)
            {
                int l = u1.licznik * u2.mianownik + u2.licznik * u1.mianownik;
                int m = u1.mianownik * u2.mianownik;
                return new Ulamek(l, m);
            }
            else
            {
                int l = u1.licznik + u2.licznik;
                int m = u1.mianownik;
                return new Ulamek(l, m);

            }
        }
        
        public static Ulamek operator -(Ulamek u)
        {
            return new Ulamek(-u.licznik, u.mianownik);
        }
        public static Ulamek operator *(Ulamek u1, Ulamek u2)
        {
            int l = u1.licznik * u2.licznik;
            int m = u1.mianownik * u2.mianownik;
            return new Ulamek(l, m);
        }
        public static Ulamek operator /(Ulamek u1, Ulamek u2)
        {
            int l = u1.licznik * u2.mianownik;
            int m = u1.mianownik * u2.licznik;
            return new Ulamek(l, m);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Ulamek u1 = new Ulamek(2,4);
            Console.WriteLine(u1);
            Console.WriteLine(u1.wartoscDziesietna);

            Ulamek u2 = new Ulamek(4,8);
            Console.WriteLine(u2);
            Console.WriteLine(u2.wartoscDziesietna);
            Console.WriteLine("Dodawanie Ułamków");
            Console.WriteLine(u1 + u2); Console.WriteLine("Odejmowanie Ułamków");
            Console.WriteLine(-u1); Console.WriteLine("Mnożenie Ułamków"); ;
            Console.WriteLine(u1 * u2); Console.WriteLine("Dzielenie Ułamków");
            Console.WriteLine(u1 / u2); 
        }
    }
}