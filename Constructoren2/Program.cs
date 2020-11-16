using System;

namespace Constructoren2
{
    using System;
    class Rechthoek
    {
        public double Hoogte { get; set; }
        public double Breedte { get; set; }
        public double Oppervlakte() { return Hoogte * Breedte; }
    }
    class Program
    {
        static void Main()
        {
            Rechthoek r1 = new Rechthoek() { Hoogte = 5, Breedte = 4 };
            Rechthoek r2 = new Rechthoek() { Hoogte = 50, Breedte = 40 };

            Console.WriteLine(r1.Oppervlakte());
            Console.WriteLine(r2.Oppervlakte());

            Console.ReadLine();
        }
    }

}
