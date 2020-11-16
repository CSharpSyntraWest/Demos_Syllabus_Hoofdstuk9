using System;

namespace Containment
{
    using System;
    class Bankrekening
    {
        public Filiaal Filiaal { get; set; }
        public Klant Klant { get; set; }
        //IbanNummer, Stort, HaalAf, Saldo, ...
    }
    class Filiaal
    {
        public string KantoorHouder { get; set; }
        public Adres Adres { get; set; }
        //KantoonNummer, ...
    }
    class Klant
    {
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        //Bankrekeningen, ...
    }
    class Adres
    {
        public string Straat { get; set; }
        public string Nummer { get; set; }
        public string Postcode { get; set; }
        //Gemeente, Land, ...
    }
    class Program
    {
        static void Main()
        {
            Adres a1 = new Adres { Postcode = "9000" };
            Adres a2 = new Adres { Postcode = "2000" };

            Klant k1 = new Klant { Naam = "Jan", Adres = a1 };
            Klant k2 = new Klant { Naam = "An", Adres = a1 };

            Filiaal f1 = new Filiaal { KantoorHouder = "Piet", Adres = a2 };

            Bankrekening b1 = new Bankrekening { Filiaal = f1, Klant = k1 };

            Console.WriteLine(b1.Filiaal.KantoorHouder); // Piet
            Console.WriteLine(b1.Klant.Adres.Postcode);  // 9000

            Console.ReadLine();
        }
    }
}

