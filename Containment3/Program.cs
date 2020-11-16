using System;

namespace Containment3
{
    using System;
    class Bankrekening
    {
        public void Stort(decimal bedrag)
        {
            Saldo += bedrag;
        }
        public void HaalAf(decimal bedrag)
        {
            Saldo -= bedrag;
        }
        public decimal Saldo { get; private set; }
        public Iban Iban { get; set; } = new Iban();
    }
    class Iban
    {
        public string Nummer { get; set; }
        public string LandCode
        {
            get { return Nummer.Substring(0, 2); }
        }
        public string IdentificatieNummer
        {
            get { return Nummer.Substring(4, 10); }      // Vanaf het vijfde karakter, behalve de laaste 2
        }
        public string CheckSum
        {
            get { return Nummer.Substring(Nummer.Length - 2); }      // laatste 2 karakters
        }
        public bool IsGeldigIbanNummer()
        {
            bool isGeldig = (long.Parse(CheckSum) == long.Parse(IdentificatieNummer) % 97);
            return isGeldig;
        }
        
    }
    class Program
    {
        static void Main()
        {
            Bankrekening bankrekening1 = new Bankrekening();

            //bankrekening1.Iban = new Iban(); // is overbodig
            bankrekening1.Iban.Nummer = "BE68539007547034";

            Console.WriteLine(bankrekening1.Iban.Nummer);                // BE68539007547034
            Console.WriteLine(bankrekening1.Iban.LandCode);              // BE
            Console.WriteLine(bankrekening1.Iban.IsGeldigIbanNummer());  // true

            Console.ReadLine();
        }
    }
}

