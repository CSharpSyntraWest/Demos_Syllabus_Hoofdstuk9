using System;

namespace VoorwaardelijkeOperatoren
{
    using System;

    class Persoon
    {
        public string Naam { get; set; }
        public bool IsVrouw { get; set; }
        public Adres Adres { get; set; }
    }
    class Adres
    {
        //...
        public string Gemeente { get; set; }
    }

    class Program1
    {
        static void Main()
        {
            Persoon klant1 = new Persoon { Adres = new Adres() { Gemeente = "Gent" } };
            Persoon klant2 = new Persoon { Adres = new Adres() };
            Persoon klant3 = new Persoon { IsVrouw = true };

            //Controle met een klassiek conditioneel statement:
            if (klant1.Adres != null)
                Console.WriteLine("van klant 1 kennen we een adres");

            //Controle met een conditionele operator:
            Console.WriteLine("klant 3 is een " + (klant3.IsVrouw ? "vrouw" : "man"));

            //Controle met null-coalescing operator:
            Console.WriteLine("klant 1 is een inwoner van: " + (klant1.Adres.Gemeente ?? "onbekend"));
            Console.WriteLine("klant 2 is een inwoner van: " + (klant2.Adres.Gemeente ?? "onbekend"));

            //Controle met voorwaardelijke dot operator:
            Console.WriteLine("klant 1 is een inwoner van: " + (klant1?.Adres?.Gemeente));
            Console.WriteLine("klant 2 is een inwoner van: " + (klant2?.Adres?.Gemeente));
            Console.WriteLine("klant 3 is een inwoner van: " + (klant2?.Adres?.Gemeente));

            Console.ReadLine();
        }
    }
}

