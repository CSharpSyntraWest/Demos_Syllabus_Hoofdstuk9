using System;

namespace ReadonlyProperty

{
    using System;
    class Document
    {
        public Document(string bestandsnaam)
        {
            Bestandsnaam = bestandsnaam;
        }
        public string Bestandsnaam { get; }
    }
    class Program
    {
        static void Main()
        {
            Document d1 = new Document("Recept.txt");
            Console.WriteLine("Bestand: " + d1.Bestandsnaam);

            //d1.Bestandsnaam = "Uitnodiging.doc"; // kan niet

            Console.ReadLine();
        }
    }
}

