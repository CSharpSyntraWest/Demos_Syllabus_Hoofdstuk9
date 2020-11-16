using System;

namespace AutoImplemented
{
    using System;
    class Bankrekening
    {
        //private string _klantNaam;
        public string KlantNaam { get; set; }
        //{
        //    get { return _klantNaam; }
        //    set { _klantNaam = value; }
        //}

        private string _nummer;
        public string IbanNummer
        {
            get
            {
                return _landCode + _nummer;
            }
            set
            {
                _landCode = value.Substring(0, 2);
                _nummer = value.Substring(2);
            }
        }
        public string Nummer
        {
            get { return _nummer; }
        }

        private string _landCode;
        public string LandCode
        {
            get { return _landCode; }
        }
    }
    class Program
    {
        static void Main()
        {
            Bankrekening bankrekening1 = new Bankrekening();

            bankrekening1.IbanNummer = "BE68539007547034";
            Console.WriteLine(bankrekening1.IbanNummer);
            Console.WriteLine(bankrekening1.LandCode);
            Console.WriteLine(bankrekening1.Nummer);

            bankrekening1.KlantNaam = "Jan Janssens";
            Console.WriteLine(bankrekening1.KlantNaam);

            Console.ReadLine();
        }
    }

}
