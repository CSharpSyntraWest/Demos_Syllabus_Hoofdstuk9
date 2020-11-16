using System;

namespace Containment2
{
    using System;
    class Verbruik
    {
        public double Hoeveelheid { get; set; }
        public Product Product { get; set; }
        public decimal TotaalPrijs()
        {
            decimal totaalPrijs = 0m;
            if (Product != null)
            {
                totaalPrijs = Product.Eenheidsprijs * (decimal)Hoeveelheid;
            }
            return totaalPrijs;
        }
    }
    class Product
    {
        public string Naam { get; set; }
        public decimal Eenheidsprijs { get; set; }
    }
    class Program2
    {
        static void Main()
        {
            Product p1 = new Product() { Eenheidsprijs = 20m };
            Verbruik v1 = new Verbruik() { Hoeveelheid = 50d, Product = p1 };

            Console.WriteLine(v1.TotaalPrijs()); // 1000
            Console.ReadLine();
        }
    }
}

