namespace CS7
{
    class Tablica
    {
        int[] tablicaZ;
        int rozmiar;
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
        public void WyswietlTablica()
        {
            System.Console.Write("Wszystkie elementy tablicy: \n");
            for (int i = 0; i < rozmiar; i++)
            {
                System.Console.Write(i +" :"+tablicaZ[i] + " \n");
            }
            System.Console.WriteLine("\n");
        }
        public void WyszukajElement(int element)
        {
            for (int i = 0; i < rozmiar; i++)
            {
                if (tablicaZ[i] == element)
                {
                    System.Console.WriteLine("Znalazlem element: " + element + " na pozycji: " + i);
                    return;
                }
            }
        }
        public void WyswietlNieparzyste()
        {
            int count = 0;
            System.Console.Write("Nieparzyste elementy tablicy: \n");
            for (int i = 0; i < rozmiar; i++)
            {
                if (tablicaZ[i] % 2 == 1)
                {
                    System.Console.Write(i + " :" + tablicaZ[i] + " \n");
                    count++;
                }
            }
            System.Console.WriteLine("Liczba nieparzystych elementow: " + count);
            System.Console.WriteLine();
        }
        public void SredniaArtymetyczna()
        {
            int suma = 0;
            for (int i = 0; i < rozmiar; i++)
            {
                suma += tablicaZ[i];
            }
            double srednia = (double)suma / rozmiar;
            System.Console.WriteLine("Srednia arytmetyczna elementow tablicy: " + srednia);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica T1 = new Tablica(100);
            T1.WyswietlTablica();
            T1.WyszukajElement(732);
            T1.WyswietlNieparzyste();
            T1.SredniaArtymetyczna();
        }
    }
}