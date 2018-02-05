using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD t1 = new ThreeD(3, 4, 5);
            ThreeD t2 = new ThreeD(0, 6, 8);
            ThreeD t3 = new ThreeD(1, 2, 3);
            ThreeD t4 = new ThreeD(4, 5, 6);
            ThreeD res = t1 + t2;
            WriteLine(ThreeD.ThreeDString(res));
            WriteLine(t1 < t2);
            WriteLine(t1 & t2);
            WriteLine(t1 | t2);
            WriteLine((t3 & t4) ? "Selam" : "Sanane");
        }
    }
    class ThreeD
    {
        int X, Y, Z;
        public ThreeD(int X = 0, int Y = 0, int Z = 0)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public static ThreeD operator +(ThreeD t1, ThreeD t2)
        {
            ThreeD result = new ThreeD();
            result.X = t1.X + t2.X;
            result.Y = t1.Y + t2.Y;
            result.Z = t1.Z + t2.Z;
            return result;
        }
        public static bool operator <(ThreeD t1, ThreeD t2)
        {
            double D1 = Sqrt(Pow(t1.X, 2));
            double D2 = Sqrt(Pow(t2.X, 2));
            return D1 < D2;
        }
        public static bool operator >(ThreeD t1, ThreeD t2)
        {
            double D1 = Sqrt(Pow(t1.X, 2));
            double D2 = Sqrt(Pow(t2.X, 2));
            return D1 > D2;
        }
        public static bool operator true(ThreeD t) { return ((t.X != 0) || (t.Y != 0) || (t.Z != 0)) ? true : false; }
        public static bool operator false(ThreeD t) { return ((t.X == 0) || (t.Y == 0) || (t.Z == 0)) ? true : false; }

        public static bool operator |(ThreeD t1, ThreeD t2) { return (t1.X != 0 || t1.Y != 0 || t1.Z != 0 || t2.X != 0 || t2.Y != 0 || t2.Z != 0) ? true : false; }
        public static bool operator &(ThreeD t1, ThreeD t2) { return (t1.X != 0 && t1.Y != 0 && t1.Z != 0 && t2.X != 0 && t2.Y != 0 && t2.Z != 0) ? true : false; }
        //public static ThreeD operator &(ThreeD t1, ThreeD t2) { return (t1.X != 0 && t1.Y != 0 && t1.Z != 0 && t2.X != 0 && t2.Y != 0 && t2.Z != 0) ? new ThreeD(1,1,1) : new ThreeD(); }
        //public static ThreeD operator |(ThreeD t1, ThreeD t2) { return (t1.X != 0 || t1.Y != 0 || t1.Z != 0 || t2.X != 0 || t2.Y != 0 || t2.Z != 0) ? new ThreeD(1, 1, 1) : new ThreeD(); }
        static public string ThreeDString(ThreeD t) { return String.Format(t.X + " " + t.Y + " " + t.Z); }
    }
}
