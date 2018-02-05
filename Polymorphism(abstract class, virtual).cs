using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Polymorphism
{
    class Program
    {   
        static void Main(string[] args)
        {
            /*
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            Shape s = new Shape(); 
            c.CallArea(r);
            c.CallArea(t);
            c.CallArea(s);
            ReadKey();*/

            Rectangle r = new Rectangle(10, 5);
            WriteLine(r.area());
        }
    }
    /*
    class Shape
    {
        protected int width, height;

        public Shape(int width = 0, int height = 0)
        {
            this.width = width;
            this.height = height;
        }

        public virtual int area()
        {
            WriteLine("Parent class area: ");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b) { }

        public override int area()
        {
            WriteLine("Rectangle class area: ");
            return (width * height);
        }
    }
    
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b) { }

        public override int area()
        {
            WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            WriteLine("Area: " + a);
        }
    }
    */

    abstract class Shape { public abstract int area(); }
    class Rectangle : Shape
    {
        int length, width;

        public Rectangle(int length = 0, int width = 0)
        {
            this.length = length;
            this.width = width;
        }
        public override int area()
        {
            WriteLine("Rectangle class area: ");
            return (width * length);
        }
    }
}
