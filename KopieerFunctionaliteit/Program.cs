using System;

namespace KopieerFunctionaliteit
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
        private string _klantnaam;
        public string Klantnaam
        {
            get { return _klantnaam; }
            set { _klantnaam = value; }
        }

        public Bankrekening Clone()
        {
            Bankrekening c = new Bankrekening();
            c.IbanNummer = IbanNummer;
            c.Klantnaam = Klantnaam;
            return c;
        }
    }
    class Program
    {
        static void Main()
        {
            Bankrekening bankrekening1 = new Bankrekening();
            bankrekening1.IbanNummer = "BE68539007547034";
            bankrekening1.Klantnaam = "Jan";
            do
            {
                Print(bankrekening1);

                Bankrekening backupBankrekening1 = bankrekening1.Clone();

                Console.Write("Nieuw IBAN nummer?: ");
                string ibanNummer = Console.ReadLine();
                bankrekening1.IbanNummer = ibanNummer;

                Console.Write("Nieuwe klantnaam?: ");
                string klantnaam = Console.ReadLine();
                bankrekening1.Klantnaam = klantnaam;

                Print(bankrekening1);

                Console.Write("Tevreden met het resultaat (ja/nee)?: ");
                string tevreden = Console.ReadLine();
                if (tevreden == "nee") bankrekening1 = backupBankrekening1;
            } while (true);
        }
        static void Print(Bankrekening b)
        {
            Console.WriteLine($"Rekening van {b.Klantnaam} met nummer {b.IbanNummer}.");
        }
    }

}
