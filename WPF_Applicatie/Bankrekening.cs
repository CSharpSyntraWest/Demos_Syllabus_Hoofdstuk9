using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Applicatie
{

    using System;
    class Bankrekening
    {
        private decimal _saldo;
        public decimal Saldo { get { return _saldo; } }
        public void Stort(decimal bedrag) { _saldo += bedrag; }
        public void HaalAf(decimal bedrag) { _saldo -= bedrag; }
        public void SchrijfOver(decimal bedrag, Bankrekening doel)
        {
            HaalAf(bedrag);
            doel.Stort(bedrag);
        }
        public string IbanNummer { get; set; }
        public string Uittreksel()
        {
            return $"{IbanNummer} heeft een saldo van {Saldo} op {DateTime.Now}.";
        }
    }

}
