using System;

namespace ReadonlyVelden
{
    using System;
    class Program
    {
        static void Main()
        {
            OGM ogm1 = new OGM("090933755493");
            OGM ogm2 = new OGM("090", "9337", "55493");
            OGM ogm3 = new OGM(90933755493);

            Console.WriteLine(ogm1.GestructureerdeMededeling);  // +++090/9337/55493+++
            Console.WriteLine(ogm2.GestructureerdeMededeling);  // +++090/9337/55493+++
            Console.WriteLine(ogm3.GestructureerdeMededeling);  // +++090/9337/55493+++

            //ogm1.GestructureerdeMededeling = "090933755493";  // kan niet (wegens readonly property)

            Console.ReadLine();
        }
    }
    class OGM  // Overschrijving Gestructureerde Mededeling
    {
        public OGM(string groep1, string groep2, string groep3) : this(groep1 + groep2 + groep3) { }
        public OGM(string gestructureerdeMededeling) : this(long.Parse(gestructureerdeMededeling)) { }
        public OGM(long gestructureerdeMededeling)
        {
            long rest = gestructureerdeMededeling % 100;
            if (((gestructureerdeMededeling - rest) / 100) % 97 == rest)
                _mededeling = gestructureerdeMededeling;
        }

        private readonly long _mededeling;
        public string GestructureerdeMededeling
        {
            get
            {
                string gm = _mededeling.ToString().PadLeft(12, '0');
                gm = "+++" + gm.Substring(0, 3) + "/" + gm.Substring(3, 4) + "/" + gm.Substring(7, 5) + "+++";
                return gm;
            }
        }

        public void TestWijzigenReadonlyVeld()
        {
            //_gestructureerdeMededeling = "090/9337/55493";  // kan niet (wegens readonly field)
        }
    }
}

