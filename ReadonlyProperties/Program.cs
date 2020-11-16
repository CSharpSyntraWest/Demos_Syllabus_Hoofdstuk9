using System;

namespace ReadonlyProperties
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
        public string LandCode
        {
            get { return IbanNummer.Substring(0, 2); }   // Eerste twee karakters.
        }
        public string ControleGetal
        {
            get { return IbanNummer.Substring(2, 2); }   // Derde en vierde karakters.
        }
        public string IdentificatieNummer
        {
            get { return IbanNummer.Substring(4,10); }      // Vanaf het vijfde karakter, behalve de laaste 2
        }
        public string CheckSum
        {
            get { return IbanNummer.Substring(IbanNummer.Length-2); }      // laatste 2 karakters
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

            bankrekening1.IbanNummer = "BE68539007547034";             // Instellen property.

            Console.WriteLine(bankrekening1.LandCode);                 // Uitlezen readonly properties.
            Console.WriteLine(bankrekening1.ControleGetal);
            Console.WriteLine(bankrekening1.IdentificatieNummer);
            Console.WriteLine(bankrekening1.CheckSum);
            //bankrekening1.LandCode = "NL";                           // Instellen zou een compilefout geven.

            Console.WriteLine(bankrekening1.IsGeldigIbanNummer());     // Uitlezen function method.

            Console.ReadLine();
        }
    }

}
