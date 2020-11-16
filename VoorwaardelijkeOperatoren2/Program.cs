using System;

namespace VoorwaardelijkeOperatoren2
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] a1 = new int[] { 10, 20, 30 };
            PrintEersteWaarde(a1); // "10"

            int[] a2 = null;
            PrintEersteWaarde(a2); // ""

            int[] a3 = new int[] { };
            //PrintEersteWaarde(a3); // werpt alsnog exception op (IndexOutOfRange)

            Console.ReadLine();
        }
        static void PrintEersteWaarde(int[] getallen)
        {
            Console.WriteLine(getallen?[0]);
        }
    }

}
