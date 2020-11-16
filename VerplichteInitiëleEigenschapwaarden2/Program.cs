using System;

namespace VerplichteInitiëleEigenschapwaarden2
{
    namespace ZonderConstructor
    {
        using System;
        class Document
        {
            public string Bestandsnaam { get; set; }
            public string Locatie { get; set; }
            public string Bestandspad
            {
                get { return Locatie + Bestandsnaam; }
            }
            public DateTime LaatstGewijzigdOp { get; set; }
        }
        class Program
        {
            static void Main()
            {
                Document d1 = new Document();
                d1.Bestandsnaam = "Recept.txt";
                d1.Locatie = @"C:\Users\Thomas\";
                Console.WriteLine("Bestand: " + d1.Bestandspad);

                Document d2 = new Document();
                //geen Bestandsnaam ingesteld voor dit document
                d2.Locatie = @"C:\Mijn Documenten\";
                Console.WriteLine("Bestand: " + d2.Bestandspad);

                Document d3 = new Document();
                d3.Bestandsnaam = "Handleiding.doc";
                Console.WriteLine("Bestand: " + d3.Bestandspad);

                Console.ReadLine();
            }
        }

    }
}

