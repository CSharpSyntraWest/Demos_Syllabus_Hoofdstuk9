using System;
namespace ZonderInheritance
{
    class Rechthoek
    {
        public double Breedte { get; set; }
        public double Hoogte { get; set; }
        public string Kleur { get; set; }
    }
    class Cirkel
    {
        public double Straal { get; set; }
        public string Kleur { get; set; }
    }

    class Program
    {
        static void Print(Rechthoek r)
        {
            Console.WriteLine($"Een figuur met kleur {r.Kleur}.");
        }
        static void Print(Cirkel c)
        {
            Console.WriteLine($"Een figuur met kleur {c.Kleur}.");
        }
        static void KleurZwart(Rechthoek r)
        {
            r.Kleur = "zwart";
        }
        static void KleurZwart(Cirkel c)
        {
            c.Kleur = "zwart";
        }
        static void Main()
        {
            Rechthoek r1 = new Rechthoek { Hoogte = 5d, Breedte = 4d, Kleur = "geel" };
            Cirkel c1 = new Cirkel { Straal = 10d, Kleur = "rood" };

            Print(r1); // Een figuur met kleur geel.
            Print(c1); // Een figuur met kleur rood.

            KleurZwart(r1);
            KleurZwart(c1);

            Print(r1); // Een figuur met kleur zwart.
            Print(c1); // Een figuur met kleur zwart.

            Console.ReadLine();
        }
    }
}

