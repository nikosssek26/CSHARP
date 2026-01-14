namespace CSP4
{
    class Pralka
    {
        private int program;
        private int wirowanie;

        public Pralka() { program = 1; wirowanie = 100; }

        public void PlusWirowanie()
        {
            Console.WriteLine("Poziom Wirowania wzniesiony o 100!");
            wirowanie += 100;
            if (wirowanie > 1000)
            {
                Console.WriteLine("Za wysokie wirowanie! Ustawiam Wartość domyślną");
                wirowanie = 100;
            }
        }
        public void MinusWirowanie()
        {
            Console.WriteLine("Poziom Wirowania zniżony o 100!");
            wirowanie -= 100;
            if (wirowanie < 100)
            {
                Console.WriteLine("Za niskie wirowanie! Ustawiam Wartość domyślną");
                wirowanie = 100;
            }
        }
        public void PlusProgram()
        {
            Console.WriteLine("Program pralki wzniesiony o 1!");
            program += 1;
            if (program > 5)
            {
                Console.WriteLine("Program 6 w tej pralce nie istnieje!!");
                program = 5;
            }
        }
        public void MinusProgram()
        {
            Console.WriteLine("Program pralki zniżony o 1!");
            program -= 1;
            if (program < 1)
            {
                Console.WriteLine("Nie można zniżyć programu do zera");
                program = 1;
            }
        }
        public void Uruchom()
        {
            Console.WriteLine($"Pralka uruchomiona z programem nr.{program} oraz wirowaniem na poziomie: {wirowanie}"); 
        }
    }

    internal class Program()
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1 - codzienne \n 2 - delikatne \n 3 - jeans \n 4 - bawelna  \n 5 - eco \n \n");
            Console.WriteLine("Pierwsza pralka: \n");
            Pralka pralka = new Pralka();
            pralka.PlusProgram();
            pralka.PlusProgram();
            pralka.PlusProgram();

            pralka.PlusWirowanie();
            pralka.PlusWirowanie();
            pralka.PlusWirowanie();

            pralka.Uruchom();

            Pralka pralka2 = new Pralka();
            Console.WriteLine("\n Druga pralka: \n");
            pralka2.MinusProgram();
            pralka2.PlusProgram();
            pralka2.PlusProgram();

            pralka2.MinusWirowanie();
            pralka2.PlusWirowanie(); 
            pralka2.Uruchom();
        }
    }
}