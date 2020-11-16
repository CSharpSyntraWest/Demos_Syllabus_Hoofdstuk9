using System;

namespace TabelOpleveren
{
    using System;
    class Coordinaat
    {
        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        private int _z;
        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public int[] XYZ()
        {
            return new int[] { X, Y, Z };
        }
    }
    class Program
    {
        static void Main()
        {
            Coordinaat coordinaat1 = new Coordinaat();
            coordinaat1.X = 3;
            coordinaat1.Y = 4;
            coordinaat1.Z = 5;

            int[] positie = coordinaat1.XYZ();
            Console.WriteLine(positie[0]);       // 3
            Console.WriteLine(positie[1]);       // 4
            Console.WriteLine(positie[2]);       // 5

            Console.ReadLine();
        }
    }

}
