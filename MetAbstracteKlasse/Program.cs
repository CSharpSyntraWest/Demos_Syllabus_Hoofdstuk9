using System;


namespace MetAbstracteKlasse
{
    using System;
    abstract class Figuur
    {
        public string Kleur { get; set; }
        public virtual double Oppervlakte() { return 0d; }
    }
    class Program1
    {
        static void Main()
        {
            //Figuur f1 = new Figuur(); // kan niet -> compilefout

            Rechthoek r1 = new Rechthoek { Hoogte = 5d, Breedte = 4d };
            Cirkel c1 = new Cirkel { Straal = 10d };

            double totaleOppervlakte = TotaleOppervlakte(r1, c1);
            Console.WriteLine(totaleOppervlakte); // 334,159265358979

            Console.ReadLine();
        }
        static double TotaleOppervlakte(params Figuur[] figuren)
        {
            double totaleOppervlakte = 0d;
            foreach (Figuur f in figuren) totaleOppervlakte += f.Oppervlakte();
            return totaleOppervlakte;
        }
    }
    class Rechthoek : Figuur
    {
        public double Hoogte { get; set; }
        public double Breedte { get; set; }
        public override double Oppervlakte() { return Hoogte * Breedte; }
    }
    class Cirkel : Figuur
    {
        public double Straal { get; set; }
        public override double Oppervlakte() { return Straal * Straal * Math.PI; }
    }
}

