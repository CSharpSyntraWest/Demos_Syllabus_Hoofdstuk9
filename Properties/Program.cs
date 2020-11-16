using System;

namespace Properties
{
    using System;
    class Bankrekening
    {
        private string _ibanNummer;
        public string IbanNummer
        {
            get { return _ibanNummer; }
            set { _ibanNummer = value; }
        }
        private string _klantNaam;
        public string KlantNaam
        {
            get { return _klantNaam; }
            set { _klantNaam = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            Bankrekening bankrekening1 = new Bankrekening();

            bankrekening1.IbanNummer = "BE68539007547034";
            Console.WriteLine(bankrekening1.IbanNummer);

            bankrekening1.KlantNaam = "Jan Janssens";
            Console.WriteLine(bankrekening1.KlantNaam);

            Console.ReadLine();
        }
    }

}
