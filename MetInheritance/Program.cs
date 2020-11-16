using System;

namespace MetInheritance
{
    class Figuur
    {
        public string Kleur { get; set; }
    }
    class Rechthoek : Figuur
    {
        public double Breedte { get; set; }
        public double Hoogte { get; set; }
    }
    class Cirkel : Figuur
    {
        public double Straal { get; set; }
    }
    class Program
    {
        static void Print(Figuur f)
        {
            Console.WriteLine($"Een figuur met kleur {f.Kleur}.");
        }
        static void KleurZwart(Figuur f)
        {
            f.Kleur = "Zwart";
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

