using System;

namespace CollectiesZelfDefiniëren2
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
        static private Bank _bank = new Bank();
        static void Main()
        {
            do
            {
                PrintOverzicht();
                Console.Write("Actie (toevoegen/verwijderen)?: ");
                string actie = Console.ReadLine();
                if (actie == "toevoegen")
                {
                    Console.Write("IBAN nummer: ");
                    string ibanNummer = Console.ReadLine();
                    Console.Write("Saldo: ");
                    decimal saldo = decimal.Parse(Console.ReadLine());
                    _bank.Toevoegen(ibanNummer, saldo);
                }
                else if (actie == "verwijderen")
                {
                    Console.Write("Op positie: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    _bank.VerwijderenOp(index);
                }
                Console.WriteLine();
            } while (true);
        }
        static void PrintOverzicht()
        {
            for (int index = 0; index < _bank.Aantal; index++)
            {
                Bankrekening b = _bank[index];
                Console.WriteLine($"{index + 1}: {b.IbanNummer}: {b.Saldo}");
            }
            Console.WriteLine($"Totaal van alle saldi: {_bank.TotaleSaldo()}\n");
        }
    }
}

