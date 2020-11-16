using System;

namespace SteedsWijzigendeReturnwaarde
{
    using System;
    using System.Threading;

    class Bankrekening
    {
        private string _ibanNummer;
        public string IbanNummer
        {
            get { return _ibanNummer; }
            set { _ibanNummer = value; }
        }

        private decimal _saldo;
        public decimal Saldo
        {
            get { return _saldo; }
        }
        public void Stort(decimal bedrag)
        {
            _saldo = Saldo + bedrag;
        }

        public string Uittreksel()
        {
            return $"{IbanNummer} heeft een saldo van {Saldo} op {DateTime.Now}.";
        }
    }
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("nl-BE");
            Bankrekening bankrekening1 = new Bankrekening();
            bankrekening1.IbanNummer = "BE68539007547034";
            bankrekening1.Stort(100m);

            string uittreksel1 = bankrekening1.Uittreksel();
            Console.WriteLine(uittreksel1);

            string uittreksel2 = bankrekening1.Uittreksel();
            Console.WriteLine(uittreksel2);

            Console.ReadLine();
        }
    }

}
