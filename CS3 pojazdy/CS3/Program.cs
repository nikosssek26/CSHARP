namespace CS3
{
    abstract class SrodekTransportu
    {
        public abstract string nazwa { get; protected set; }
    }
    interface Ijedz
    {
        void jedz();
    }
    interface IPlyn
    {
        void plyn();
    }
    interface ILataj
    {
        void lec();
    }

    abstract class Ladowy : SrodekTransportu, Ijedz 
    {
        public abstract void jedz();
    }
    abstract class Wodne : SrodekTransportu, IPlyn
    {
        public abstract void plyn();

    }
    abstract class Powietrzne : SrodekTransportu, ILataj 
    {
        public abstract void lec();
    }

    class Samochod : Ladowy
    {
        public override string nazwa { get; protected set; }
        public Samochod(string nazwa) => this.nazwa = nazwa;
        public override void jedz() 
        {
            Console.WriteLine($"{nazwa} jedzie");
        }
    }
    class Kajak : Wodne 
    {
        public override string nazwa { get; protected set; }
        public Kajak(string nazwa) => this.nazwa = nazwa;
        public override void plyn()
        {
            Console.WriteLine($"{nazwa} plynie");
        }
    }
    class Samolot : Powietrzne
    {
        public override string nazwa { get; protected set; }
        public Samolot(string nazwa) => this.nazwa = nazwa;
        public override void lec()
        {
            Console.WriteLine($"{nazwa} lata");
        }
    }
    class Amfibia : Ladowy, IPlyn
    {
        public override string nazwa { get; protected set; }
        public Amfibia(string nazwa) => this.nazwa = nazwa;
        public override void jedz()
        {
            Console.WriteLine($"{nazwa} jedzie");
        }
        public void plyn()
        {
            Console.WriteLine($"{nazwa} plynie");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Samochod samochod = new Samochod("Mercedes-Benz AffalterBach C63 W204");
            Kajak kajak = new Kajak("Drewniany kajak");
            Samolot samolot = new Samolot("Cessna 172");
            Amfibia amfibia = new Amfibia("Gibbs Aquada");
        }
    }
}