using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //INHERITANCE
            /*
            Triangle t1 = new Triangle();

            t1.Height = 5;
            t1.Width = 4;
            t1.ShowDim();

            t1.Style = "İkizkenar";
            t1.ShowStyle();
            WriteLine(t1.Area());*/

            /*
            Triangle t2 = new Triangle(2,8,"İkizkenar");
            t2.ShowDim();
            t2.ShowStyle();
            WriteLine(t2.Area());
            */

            // C c = new C(); 
            /*
              C ile B ve B ile A kalıtım yaptığı için base class A dır.
              Dolayısıyla A dan başlayarak önce A nın, sonra B nin, sonra da C nin constructor u çalışır.
            */

            /*
            A a = new A(10);
            WriteLine(a.i);

            B b = new B(20);
            a = b;

            WriteLine(a.i);
            */

            /*
            Triangle t3 = new Triangle(7,8,"Eskenar");

            Triangle t4 = new Triangle(t3);

            t4.ShowDim();
            t4.ShowStyle(); 
            WriteLine(t4.Area());
            */
            /**/
            Base b = new Base();
            Derived1 d1 = new Derived1();
            Derived2 d2 = new Derived2();
            //Base2 b2 = new Base2();
            Derived3 d3 = new Derived3();
            d3.SelamVer();
            b.Who();
            //d1.Who();
            b = d1;
            b.Who();
            //d2.Who();
            b = d2;
            b.Who();

            /*
            A a = new A();
            a.i = 1;
            B b = new B();
            b.i = 2;

            B c = (B)a;

            WriteLine(c.i);

            A d = c;

            WriteLine(d.i);*/
        }
    }

    class TwoDShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public TwoDShape(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public TwoDShape(TwoDShape S)
        {
            Width = S.Width;
            Height = S.Height;
        }

        public void ShowDim() { WriteLine("Dimension w: " + Width + " h: " + Height); }
    }

    class Triangle : TwoDShape
    {
        public string Style { get; set; }
        /*public Triangle(double Width, double Height, string Style)
        {
            this.Width = Width;
            this.Height = Height;
            this.Style = Style;
        }*/
        //'base' Constructor
        public Triangle(double Width, double Height, string Style) : base(Width, Height) { this.Style = Style; }
        public Triangle(Triangle TX) : base(TX) { Style = TX.Style; }
        public double Area() { return Width * Height; }
        public void ShowStyle() { WriteLine("Triangle Style " + Style); }
    }

    class A
    {
        public int i { set; get; }

        public A(int i = 0) { this.i = i; }
        // public A() { WriteLine("A"); }
    }

    class B : A
    {
        public int j { get; set; }
        public B(int i = 0, int j = 0) : base(i) { this.j = j; }
        // public B() { WriteLine("B"); }
    }

    class C : B { public C() { WriteLine("C"); } }

    //Virtual Methods and Overriding
    class Base { public virtual void Who() { WriteLine("Base"); } }
    class Derived1 : Base { public override void Who() { WriteLine("Derived1"); } }
    class Derived2 : Base { public override void Who() { WriteLine("Derived2"); } }

    abstract class Base2 { public abstract void SelamVer(); }
    class Derived3 : Base2 { public override void SelamVer() { WriteLine("Selam"); } }
}
