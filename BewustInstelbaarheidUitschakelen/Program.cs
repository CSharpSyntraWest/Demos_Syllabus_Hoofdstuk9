using System;

namespace BewustInstelbaarheidUitschakelen
{
    using System;
    class Bankrekening
    {
        private decimal _saldo;
        public decimal Saldo
        {
            get { return _saldo; }
        }
        public void Stort(decimal bedrag)
        {
            _saldo = Saldo + bedrag;
        }
        public void HaalAf(decimal bedrag)
        {
            _saldo = Saldo - bedrag;
        }
    }
    class Program
    {
        static void Main()
        {
            Bankrekening bankrekening1 = new Bankrekening();
            bankrekening1.Stort(100m);
            bankrekening1.HaalAf(20m);
            Console.WriteLine($"Saldo: {bankrekening1.Saldo}");        // Uitlezen readonly properties.
            //bankrekening1.Saldo = 500m;                              // Instellen zou een compilefout geven.

            Console.ReadLine();
        }
    }

}
