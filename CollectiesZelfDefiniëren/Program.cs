using System;
namespace CollectiesZelfDefiniëren
{
    using System;
    using System.Collections.Generic;
    class Program
    {
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
                    Toevoegen(ibanNummer, saldo);
                }
                else if (actie == "verwijderen")
                {
                    Console.Write("Op positie: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    VerwijderenOp(index);
                }
                Console.WriteLine();
            } while (true);
        }
        static void PrintOverzicht()
        {
            for (int index = 0; index < Aantal; index++)
            {
                Bankrekening b = Item(index);
                Console.WriteLine($"{index + 1}: {b.IbanNummer}: {b.Saldo}");
            }
            Console.WriteLine($"Totaal van alle saldi: {TotaleSaldo()}\n");
        }

        static private List<Bankrekening> _items = new List<Bankrekening>();
        static int Aantal { get { return _items.Count; } }
        static void Toevoegen(string ibanNummer, decimal saldo)
        {
            Bankrekening b = new Bankrekening() { IbanNummer = ibanNummer, Saldo = saldo };
            _items.Add(b);
        }
        static void VerwijderenOp(int index)
        {
            _items.RemoveAt(index);
        }
        static Bankrekening Item(int index)
        {
            return _items[index];
        }
        static decimal TotaleSaldo()
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
}

