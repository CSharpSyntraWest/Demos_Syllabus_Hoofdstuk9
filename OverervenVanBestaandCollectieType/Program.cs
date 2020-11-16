using System;

namespace OverervenVanBestaandCollectieType
{
    using System;
    using System.Collections.Generic;
    class Tekening : List<Figuur>
    {
        public void KleurAllesZwart()
        {
            for (int index = 0; index < Count; index++)
                this[index].Kleur = "zwart";
        }
    }
    class Figuur
    {
        public string Kleur { get; set; }
    }
    class Vierkant : Figuur
    {
        public double Zijde { get; set; }
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
        static void Main()
        {
            Rechthoek r1 = new Rechthoek { Hoogte = 5d, Breedte = 4d, Kleur = "geel" };
            Cirkel c1 = new Cirkel { Straal = 10d, Kleur = "rood" };
            Vierkant v1 = new Vierkant { Zijde = 15d, Kleur = "blauw" };

            Tekening tekening1 = new Tekening();
            tekening1.Add(r1);
            tekening1.Add(c1);
            Print(tekening1);

            List<Figuur> tekening2 = new List<Figuur>();
            tekening2.Add(c1);
            tekening2.Add(v1);
            Print(tekening2);

            Console.ReadLine();
        }
        static void Print(List<Figuur> fn)
        {
            for (int index = 0; index < fn.Count; index++)
            {
                Figuur f = fn[index];
                Console.WriteLine($"- Een figuur met kleur {f.Kleur}.");
            }
            Console.WriteLine("\n");
        }
    }
}

