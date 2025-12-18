namespace CS8
{
    class  Tablica
    {
        private int[] tablicaZ;
        private int rozmiar;
        public Tablica(int rozmiar)
        {
            this.rozmiar = rozmiar;
            tablicaZ = new int[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                Random rand = new Random();
                tablicaZ[i] = rand.Next(1, 1000);
            }
        }
        public void Wyswietl()
        {
            foreach (var item in tablicaZ)
                Console.Write("nr:"+item + " \n");
        }
        public void ZnajdzLiczbe(int liczba)
        {
            for (int i = 0; i < rozmiar; i++)
            {
                if (tablicaZ[i] == liczba)
                {
                    Console.WriteLine("Znaleziono liczbę: " + liczba + " na pozycji: " + i);
                    return;
                }
            }
            Console.WriteLine("Nie znaleziono liczby: " + liczba);
        }
        public void IleLiczbNieparzystych()
        {
            int licznik = 0;
            for (int i = 0; i < rozmiar; i ++)
            {
                if (tablicaZ[i] % 2 != 0)
                {
                    licznik++;
                }
            }
            Console.WriteLine("Liczba nieparzystych elementów w tablicy to: " + licznik);
        }
        public void SredniaArytmetyczna()
        {
            int suma = 0;
            for (int i = 0; i < rozmiar; i++)
            {
                suma += tablicaZ[i];
            }
            double srednia = (double)suma / rozmiar;
            Console.WriteLine("Średnia arytmetyczna wszystkich wartosci w tablicy to: " + srednia);
        }
        public void OdrwocTablice()
        {
            Array.Reverse(tablicaZ);
        }
        public void NajczesciejWystepujacaLiczba()
        {
            var licznik = new Dictionary<int, int>();
            for (int i = 0; i < rozmiar; i++)
            {
                if (licznik.ContainsKey(tablicaZ[i]))
                {
                    licznik[tablicaZ[i]]++;
                }
                else
                {
                    licznik[tablicaZ[i]] = 1;
                }
            }
            int najczesciejWystepujacaLiczba = tablicaZ[0];
            int maxIloscWystapien = 1;
            foreach (var para in licznik)
            {
                if (para.Value > maxIloscWystapien)
                {
                    maxIloscWystapien = para.Value;
                    najczesciejWystepujacaLiczba = para.Key;
                }
            }
            Console.WriteLine("Najczęściej występująca liczba to: " + najczesciejWystepujacaLiczba + " występuje: " + maxIloscWystapien + " razy.");
        }
        public void ZerujElement(int liczba)
        {
            for( int i = 0 ; i < rozmiar; i++)
            {
                if(tablicaZ[i] == liczba)
                {
                    tablicaZ[i] = 0;
                }
            }
        }
        public void SortujTablicaAsc()
        {
            Console.WriteLine("\nTABLICA POSORTOWANA ROSNACO: ");
            Array.Sort(tablicaZ);
        }
        public void SortujTablicaDesc()
        {
            Console.WriteLine("\nTABLICA POSORTOWANA MALEJACO: ");  
            Array.Sort(tablicaZ);
            Array.Reverse(tablicaZ);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica tablica = new Tablica(10);
            tablica.Wyswietl();
            tablica.ZnajdzLiczbe(89);
            tablica.IleLiczbNieparzystych();
            tablica.SredniaArytmetyczna();
            tablica.NajczesciejWystepujacaLiczba();
            tablica.ZerujElement(89);
            tablica.SortujTablicaAsc();
            tablica.Wyswietl();
            tablica.SortujTablicaDesc();
            tablica.Wyswietl();
            Console.WriteLine("\nTABLICA 2 ODWROCONA: ");
            Tablica tablica1 = new Tablica(10);
            tablica1.OdrwocTablice();
            tablica1.Wyswietl();
        }
    }
}