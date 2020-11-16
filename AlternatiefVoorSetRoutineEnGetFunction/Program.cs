using System;

namespace AlternatiefVoorSetRoutineEnGetFunction
{
    using System;
    class Bankrekening
    {
        private string _ibanNummer;
        public string GetIbanNummer()
        {
            return _ibanNummer;
        }
        public void SetIbanNummer(string value)
        {
            _ibanNummer = value;
        }
        private string _klantNaam;
        public string GetKlantNaam()
        {
            return _klantNaam;
        }
        public void SetKlantNaam(string value)
        {
            _klantNaam = value;
        }
    }
    class Program
    {
        static void Main()
        {
            Bankrekening bankrekening1 = new Bankrekening();

            bankrekening1.SetIbanNummer("BE68539007547034");
            Console.WriteLine(bankrekening1.GetIbanNummer());

            bankrekening1.SetKlantNaam("Jan Janssens");
            Console.WriteLine(bankrekening1.GetKlantNaam());

            Console.ReadLine();
        }
    }

}
