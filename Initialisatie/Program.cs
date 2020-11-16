using System;

namespace Initialisatie
{
    using System;
    class Program
    {
        static void Main()
        {
            Artikel artikel1 = new Artikel();
            Console.WriteLine(artikel1.BtwPercentage); // 21

            artikel1.BtwPercentage = 6m;
            Console.WriteLine(artikel1.BtwPercentage); //  6

            Console.ReadLine();
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
