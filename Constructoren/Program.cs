using System;

namespace Constructoren
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
            Rechthoek r1 = new Rechthoek();
            Rechthoek r2 = new Rechthoek();
            Rechthoek r3 = new Rechthoek();
            Rechthoek r4 = new Rechthoek();

            r1.Hoogte = 5;                        // (1)
            r1.Breedte = 4;                       // (1)

            r2.Hoogte = 50;                       // (1)
            r2.Breedte = 40;                      // (1)

            Console.WriteLine(r1.Oppervlakte());  // (2)
            Console.WriteLine(r2.Oppervlakte());  // (2)

            Console.WriteLine(r3.Oppervlakte());  // (3) -> geen verschil met r4
            Console.WriteLine(r4.Oppervlakte());  // (3) -> geen verschil met r3

            Console.ReadLine();
        }
    }

}
