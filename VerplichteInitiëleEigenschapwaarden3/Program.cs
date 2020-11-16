using System;

namespace VerplichteInitiëleEigenschapwaarden3
{
    namespace MetConstructor
    {
        using System;
        class Document
        {
            public Document(string bestandsnaam)
            {
                Bestandsnaam = bestandsnaam;
            }
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
                Document d1 = new Document("Recept.txt");
                Console.WriteLine("Bestand: " + d1.Bestandspad);

                //Document d2 = new Document();  // kan niet meer

                Console.ReadLine();
            }
        }
    }
}

