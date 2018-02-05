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

            koord.X = 20;
            koord.Y = 40;

            FailSoftArray2D fs1 = new FailSoftArray2D(2,3);
            fs1[4,4] = 15;
            Write(fs1.ErrFlag); Write(" " + fs1[4,4]);
        }
    }


    //indexer Kullanımı

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

    class FailSoftArray2D
    {
        int[,] a;
        public int Length;
        int row, col;
        public bool ErrFlag;

        public FailSoftArray2D(int row, int col)
        {
            this.row = row;
            this.col = col;
            a = new int[row, col];
            Length = row * col;
        }

        bool ok(int index1, int index2) { return (index1 >= 0 & index1 < row && index2 >= 0 & index2 < col) ? true : false; }
        public int this[int index1, int index2]
        {
            get
            {
                if(ok(index1, index2))
                {
                    ErrFlag = false;
                    return a[index1, index2];
                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }
            set
            {
                if (ok(index1, index2))
                {
                    a[index1, index2] = value;
                    ErrFlag = false;
                }
                else ErrFlag = true;
            }
        }
    }

    //Property kullanımı
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
