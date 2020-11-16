using System;
namespace Casting3
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            foreach (Werknemer w in _werknemers) Print(w);

            Console.ReadLine();
        }

        static void Print(Werknemer w)
        {
            Console.Write(w.Naam);
            if (w is Manager) Console.Write($" (manager)");
            Console.WriteLine();
        }

        static List<Werknemer> _werknemers = new List<Werknemer>
                                          { new Werknemer { Id = 11, Naam = "Theo" },
                                            new Manager { Id = 12, Naam = "Piet", Bonus = 18000m },
                                            new Manager { Id = 13, Naam = "Bert", Bonus = 17000m }};
    }
    class Werknemer
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }
    class Manager : Werknemer
    {
        public decimal Bonus { get; set; }
    }
}

