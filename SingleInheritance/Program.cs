using System;

namespace SingleInheritance
{
    class Persoon
    {
        public string Naam { get; set; }
    }


    class Cursist : Persoon
    {
        public Module[] IngeschrevenModules { get; set; }
    }


    class Werknemer : Persoon
    {
        public decimal Loon { get; set; }
    }
    class Docent : Werknemer
    {
        public string Anciënniteit { get; set; }
    }



    class Module
    {
        public string Naam { get; set; }
        public int Lestijden { get; set; }

    }

    class Program
    {

        static void Main()
        {
            Persoon p1 = new Persoon() { Naam = "Jan" };
            Print(p1);
            Module m1 = new Module() { Naam = "C# Programmeren 1", Lestijden = 42 };

            Werknemer w1 = new Werknemer() { Naam = "Piet", Loon = 2000 };
            Print(w1);
            Docent d1 = new Docent() { Naam = "Joris", Loon = 2500, Anciënniteit = "A1" };
            Print(d1);

            Console.ReadLine();
        }
        static void Print(Persoon persoon)
        {
            Console.Write($"Naam: {persoon.Naam} ");
            if (persoon is Werknemer)
            {
                Werknemer w = persoon as Werknemer;
                Console.Write($"Loon: {w.Loon} ");
            }
            if (persoon is Docent)
            {
                Docent d = persoon as Docent;
                Console.Write($"Anciënniteit: {d.Anciënniteit} ");
            }
            Console.WriteLine();
        }
    }
}

