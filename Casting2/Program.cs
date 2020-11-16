using System;

namespace Casting
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Manager managerA = GetWerknemer(12) as Manager;
            Console.WriteLine(managerA.Bonus);

            //Zonder variabele:
            //Console.WriteLine((GetWerknemer(12) as Manager).Bonus);

            Manager managerB = (Manager)GetWerknemer(13);
            Console.WriteLine(managerB.Bonus);

            //Zonder variabele:
            //Console.WriteLine(((Manager)GetWerknemer(13)).Bonus);

            //Cast poging '(Manager)GetWerknemer(11)' resulteert in een InvalidCastException:
            //Manager managerX = (Manager)GetWerknemer(11);

            //Expressie 'GetWerknemer(11) as Manager' evalueert naar null:
            //Manager managerY = GetWerknemer(11) as Manager;

            Console.ReadLine();
        }

        static List<Werknemer> _werknemers = new List<Werknemer>
                                          { new Werknemer { Id = 11, Naam = "Theo" },
                                            new Manager { Id = 12, Naam = "Piet", Bonus = 18000m },
                                            new Manager { Id = 13, Naam = "Bert", Bonus = 17000m }};
        static Werknemer GetWerknemer(int id)
        {
            foreach (Werknemer w in _werknemers) if (w.Id == id) return w;
            return null;
        }
    }
    class Werknemer
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }
    class Manager : Werknemer
    {
        public decimal Bonus { get; set; }
    }

}

