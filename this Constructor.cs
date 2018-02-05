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
            Person p1 = new Person();
            Show(p1);

            Console.WriteLine();
            Person p2 = new Person("Ugur","Ipekduzen");
            Show(p2);

            Console.WriteLine();
            Person p3 = new Person("Kaan", "Inel", 20, "Samsun");
            Person p4 = new Person(p3);

            Show(p4);
        }

        /*bir classta başta bir class objesini referanssız kullanmak için değişken method vs. başına static yazılır.*/
        static public void Show(Person pers)
        {
            Console.Write(pers.firstName + " " +
                          pers.lastName + " " +
                          pers.age + " " +
                          pers.city + " " );
        }
    }

    class Person
    {
        public int age;
        public string city;
        public string firstName;
        public string lastName;
        
        public Person() :this("<no name>","<no lastname>",0,"Yalova")
        {
            Console.WriteLine("Person()");
        }

        public Person(string firstName, string lastName) 
        {
            Console.WriteLine("Person(string firstName, string lastName)");
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName, string lastName, int age, string city) : this(firstName, lastName)
        {
            Console.WriteLine("Person(string firstName, string lastName, int age, string city)");
            this.age = age;
            this.city = city;
        }

        public Person(Person pers) :this(pers.firstName, pers.lastName, pers.age, pers.city)
        {
            Console.WriteLine("Person(Person pers)");
        }
    }

    
}
