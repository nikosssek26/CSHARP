namespace CS2
{
    class Tablica
    {
        public int[] tab = new int[3];
        public Tablica(int[] tab)
        {
            this.tab = tab;
        }
        public Tablica()
        {
            tab= [0,0,0,];
        }
        public Tablica(Tablica tab)
        {
            //this.tab = tab.tab;
            for (int i=0; i<tab.tab.Length; i++)
                this.tab[i] = tab.tab[i];
        }

        public override string ToString()
        {
            string s ="";
            foreach (int i in tab)
                s+= i.ToString() + " ";
                return s;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica t1 = new Tablica();
            Tablica t2 = new Tablica(new int[3] {1,2,3});
            Tablica t3 = new Tablica(t2);
            t3.tab[0] = 100;
            System.Console.WriteLine(t1);
            System.Console.WriteLine(t2);
            System.Console.WriteLine(t3);
        }
    }
}