using System;
namespace Casting
{
    using System;
    class Program
    {
        static void Main()
        {
            Werknemer w1 = new Manager { Naam = "Piet", Bonus = 18000m };
            Console.WriteLine($"Naam: {w1.Naam}");
            //Console.WriteLine($"Bonus: {w1.Bonus}");  // kan niet (compilefout)

            Manager w2 = new Manager { Naam = "Bert", Bonus = 17000m };
            Console.WriteLine($"Naam: {w2.Naam}");
            Console.WriteLine($"Bonus: {w2.Bonus}");    // kan wel

            Console.ReadLine();
        }
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

