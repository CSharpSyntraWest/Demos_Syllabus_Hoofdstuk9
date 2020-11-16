using System;

namespace CollectiesZelfDefiniëren3
{
    using System;
    using System.Collections.Generic;
    class Bank
    {
        private List<Bankrekening> _items = new List<Bankrekening>();
        public int Aantal { get { return _items.Count; } }
        public void Toevoegen(string ibanNummer, decimal saldo)
        {
            Bankrekening b = new Bankrekening() { IbanNummer = ibanNummer, Saldo = saldo };
            _items.Add(b);
        }
        public void VerwijderenOp(int index)
        {
            _items.RemoveAt(index);
        }
        public Bankrekening this[int index]
        {
            get
            {
                return _items[index];
            }
        }
        public decimal TotaleSaldo()
        {
            decimal totaleSaldo = 0m;
            foreach (Bankrekening b in _items) totaleSaldo += b.Saldo;
            return totaleSaldo;
        }
    }
    class Bankrekening
    {
        public string IbanNummer { get; set; }
        public decimal Saldo { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Bank collectieX = new Bank();
            int[] collectieY = new int[] { 10, 20, 30 };

            collectieX.Toevoegen("BE68539007547034", 0);

            Bankrekening b1 = collectieX[0];
            int i1 = collectieY[0];

            Console.WriteLine(b1.IbanNummer); // BE68539007547034
            Console.WriteLine(i1);            // 10

            Console.ReadLine();
        }
    }
}
