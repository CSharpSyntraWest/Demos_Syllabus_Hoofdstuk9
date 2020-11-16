using System;

namespace MetInheritance3
{
    using System;
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
    class Tekening
    {
        private Figuur[] _items = { };
        public Figuur this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }
        public int Count
        {
            get { return _items.Length; }
        }
        public void Add(Figuur item)
        {
            Array.Resize(ref _items, Count + 1);
            _items[Count - 1] = item;
        }
        public void KleurAllesZwart()
        {
            for (int index = 0; index < Count; index++)
                this[index].Kleur = "zwart";
        }
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
            tekening1.Add(v1);

            Print(tekening1); // - Een figuur met kleur geel.
                              // - Een figuur met kleur rood.
                              // - Een figuur met kleur blauw.

            tekening1.KleurAllesZwart();

            Print(tekening1); // - Een figuur met kleur zwart.
                              // - Een figuur met kleur zwart.
                              // - Een figuur met kleur zwart.

            Console.ReadLine();
        }
        static void Print(Tekening fn)
        {
            for (int index = 0; index < fn.Count; index++)
            {
                Figuur f = fn[index];
                Console.WriteLine($"- Een figuur met kleur {f.Kleur}.");
            }
            Console.WriteLine();
        }
    }
}
