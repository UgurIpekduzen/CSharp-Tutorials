using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 10;
            Console.WriteLine(i);//10 basar
            Degistir(i); // i değerinin sadece değerini gönderdik referansını değil
            Console.WriteLine(i);//10 basar

            Point p5 = new Point(30, 50);
            p5.Show();
            DegistirP(p5);
            p5.Show();
            

            int x = IntOku("Bir sayi giriniz");
            Console.WriteLine(x);
            Sqr(ref x);
            Console.WriteLine("x " + x);

            int y = IntOku("Bir sayi daha giriniz");

            SwapValues(ref x, ref y);
            Console.WriteLine("x" + x);
            Console.WriteLine("y" + y);

            double FNum;
            int WNum = GetParts(34.6, out FNum);

            Console.WriteLine("F " + FNum);
            Console.WriteLine("w " + WNum);
            */

            Point Px = new Point(10,10);
            Px.Show();

            Point Py = new Point(20,20);
            Py.Show();

            Swap(ref Px, ref Py);
            Px.Show();
            Py.Show();
        }

        static void Swap(ref Point P1, ref Point P2)
        {
            Point temp = P1;
            P1 = P2;
            P2 = temp;
        }

        static int IntOku(string yazi)
        {
            int sayi;
            Console.WriteLine(yazi);
            sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }

        static void Degistir(int A) { A = A + 20; }
        static void DegistirP(Point P) { P.SetX(21); }

        static void Sqr(ref int i) { i *= i; }
        static void SwapValues(ref int Num1, ref int Num2)
        {
            int Temp = Num1;
            Num1 = Num2;
            Num2 = Temp;
        }

        static int GetParts(double Number, out double Fract)
        {
            int Whole = (int)Number;
            Fract = Number - Whole;
            return Whole;
        }
    }

    class Point
    {
        int x, y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool SameAs(Point p)
        {
            if ((x == p.x) && (y == p.y)) return true;
            else return false;
        }

        public void Copy(Point p)
        {
            x = p.x;
            y = p.y;
        }

        public void Show()
        {
            Console.WriteLine(x + " " + y);
        }
        
        public void SetX(int x) { this.x = x; }
        public void SetY(int y) { this.y = y; }
    }
}
