using System;

namespace ObjectInitializers
{
    using System;
    class Program
    {
        static void Main()
        {
            Artikel artikel1 = new Artikel() { Prijs = 1000m, BtwPercentage = 6m };

            //In plaats van 3 regels:
            //Artikel artikel1 = new Artikel();
            //artikel1.Prijs = 1000m;
            //artikel1.BtwPercentage = 6m;

            Artikel artikel2 = new Artikel() { Prijs = 200m };

            //In plaats van 2 regels:
            //Artikel artikel2 = new Artikel();
            //artikel2.Prijs = 200m;

            PrintArtikel(artikel1);
            PrintArtikel(artikel2);

            Console.ReadLine();
        }
        static void PrintArtikel(Artikel a)
        {
            Console.WriteLine($"Artikel met prijs {a.PrijsInclusiefBtw} (inclusief BTW).");
        }
    }
    class Artikel
    {
        public decimal Prijs { get; set; }
        public decimal BtwPercentage { get; set; } = 21m;
        public decimal PrijsInclusiefBtw
        {
            get { return Prijs * (1 + (BtwPercentage / 100)); }
        }
    }

}
