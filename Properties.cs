using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace PointSquareTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FSArray fa = new FSArray(10);
            fa[0] = 21;
            WriteLine(fa[1000]);*/

            Koord koord = new Koord();

            koord.x = 20;
            koord.y = 40;

        }
    }


    //Property Kullanımı

    class FSArray
    {
        int[] a;

        public FSArray(int size)
        {
            a = new int[size];
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= a.Length) return 0;
                return a[index];
                /*
                if (index == 2) return 30;
                return a[index];*/
                //return a[index];
            }
            set
            {
                if (!(index < 0 || index >= a.Length))
                    a[index] = value;
                //a[index] = value;
            }
        }
    }

    class Koord
    {
            private int x;

            public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z { get; set; }
    }
}
