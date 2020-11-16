using System;
namespace VerplichteInitiëleEigenschapwaarden
{
    using System;
    class Rechthoek
    {
        public Rechthoek(double hoogte, double breedte)
        {
            Hoogte = hoogte;     // of voor de leesbaarheid: this.Hoogte = hoogte;
            Breedte = breedte;   //                          this.Breedte = breedte;
        }
        public double Hoogte { get; set; }
        public double Breedte { get; set; }
        public double Oppervlakte() { return Hoogte * Breedte; }
    }
    class Program
    {
        static void Main()
        {
            //Rechthoek r0 = new Rechthoek(); // kan niet meer
            Rechthoek r1 = new Rechthoek(5, 4);
            Rechthoek r2 = new Rechthoek(50, 40);

            Console.WriteLine(r1.Oppervlakte()); // 20
            Console.WriteLine(r2.Oppervlakte()); // 2000

            Console.ReadLine();
        }
    }
}

