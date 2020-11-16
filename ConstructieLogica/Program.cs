using System;

namespace ConstructieLogica
{
    using System;
    class Bankrekening
    {
        public Bankrekening(string ibanNummer)
        {
            Iban = new Iban(ibanNummer);
        }
        public void Stort(decimal bedrag)
        {
            Saldo += bedrag;
        }
        public decimal Saldo { get; private set; }
        public Iban Iban { get; set; }
    }
    class Iban
    {
        public Iban(string nummer)
        {
            Nummer = nummer;
        }
        public string Nummer { get; set; }
        public string LandCode
        {
            get { return Nummer.Substring(0, 2); }
        }
    }
    class Program
    {
        static void Main()
        {
            Bankrekening b1 = new Bankrekening("BE68539007547034");
            Console.WriteLine(b1.Iban.LandCode); // BE

            Console.ReadLine();
        }
    }
}

