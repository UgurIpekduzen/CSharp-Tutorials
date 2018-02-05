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
            House h = new House();
            h.name = "Broadway";
            // Cast a House to an Apartment.
            Apartment a = (Apartment)h;
            WriteLine(a.name);
            // Apartment was converted from House.

            Machine m = new Machine();
            m.value = 5;
            WriteLine(m.value);
            // Implicit conversion from machine to widget.
            Widget w = m;
            WriteLine(w.value);
            // Implicit conversion from widget to machine.
            Machine m2 = w;
            WriteLine(m2.value);
        }
    }

    //explicit Operator
    class Apartment
    {
        public string name { get; set; }
        public static explicit operator House(Apartment a) { return new House() { name = a.name }; }
    }

    class House
    {
        public string name { get; set; }
        public static explicit operator Apartment(House h) { return new Apartment() { name = h.name }; }
    }
    //implicit Operator
    class Machine
    {
        public int value;
        public static implicit operator Widget(Machine m)
        {
            Widget w = new Widget();
            w.value = m.value * 2;
            return w;
        }
    }

    class Widget
    {
        public int value;
        public static implicit operator Machine(Widget w)
        {
            Machine m = new Machine();
            m.value = w.value / 2;
            return m;
        }
    }   
}
