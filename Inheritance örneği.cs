using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using static System.Threading.Thread;
namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("", "1 Happy Ave", "Comp. Science", 1, 200.5);
            s1.DersVeNotEkle("IM101", 97);
            s1.DersVeNotEkle("IM102", 68);
            s1.NotlariYaz();
            WriteLine("\tOrtalama: " + s1.NotOrtalamasi());
            Teacher t1 = new Teacher("Paul Tan", "8 sunset way", 5000);
            t1.DersEkle("IM101");
            t1.DersEkle("IM102");
            t1.DersEkle("IM103");
            WriteLine(t1.BilgiDondur());
            t1.DersleriYazdir();
        }
    }
    class Person
    {
        string name, address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string Name
        {
            get { return name; }
            set { if (!string.IsNullOrEmpty(value)) name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public virtual string BilgiDondur() { return string.Format("Kisi [isim: {0}, adres: {1}]", name, address); }
    }

    class Student : Person
    {
        string program;
        int year, lessonCount;
        double debt;
        string[] lessons;
        int[] grades;
        const int MAX = 10;

        public Student(string name, string address, string program,
            int year, double debt) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.debt = debt;
            lessons = new string[MAX];
            grades = new int[MAX];
            lessonCount = 0;
        }
        public string Program
        {
            get { return program; }
            set { program = value; }
        }
        public int Year
        {
            get { return year; }
            set { if (value > 0) year = value; }
        }
        public double Debt
        {
            get { return debt; }
            set { if (value >= 0) debt = value; }
        }
        public string this[int index]
        {
            get
            {
                if (index >= MAX) return "index MAX' dan buyuk";
                return lessons[index];
            }
            set { if (index < MAX) lessons[index] = value; }
        }
        public int this[string lesson]
        {
            get
            {
                int temp = IndexDondur(lesson);
                if (temp != -1) return grades[temp];
                return -1;
            }
            set
            {
                int temp = IndexDondur(lesson);
                if (temp != -1) if (value >= 0) grades[temp] = value;
            }
        }
        int IndexDondur(string lesson)
        {
            int temp = 0;
            foreach (var item in lessons)
            {
                if (item == lesson) return temp;
                temp++;
            }
            return -1;
        }
        public void DersVeNotEkle(string lesson, int grade)
        {
            this[lessonCount] = lesson;
            this[lesson] = grade;
            if (this[lessonCount] == lesson) lessonCount++;
        }
        public void NotlariYaz()
        {
            WriteLine(BilgiDondur());
            for (int i = 0; i < lessonCount; i++) WriteLine("\tDers: " + lessons[i] + "Not: " + grades[i]);
        }
        public double NotOrtalamasi()
        {
            int total = 0;
            foreach (var item in grades) total += item;
            return (double)total / lessonCount;
        }
        public override string BilgiDondur()
        {
            return base.BilgiDondur()
                    + "\nProgram: " + Program
                    + "Yil: " + Year
                    + "Ucret: " + Debt.ToString();
        }
    }

    class Teacher : Person
    {
        int lessonCount;
        string[] lessons;
        double pay;
        static readonly int MAX = 10;
        public Teacher(string name, string address, double pay) : base(name, address)
        {
            lessonCount = 0;
            this.pay = pay;
            lessons = new string[MAX];
        }
        public double Pay
        {
            get { return pay; }
            set { if (value > 0) pay = value; }
        }
        public string this[int index]
        {
            get
            {
                if (index >= MAX) return "index MAX'tan buyuk";
                return lessons[index];
            }
            set { if (index < MAX) lessons[index] = value; }
        }
        public void DersEkle(string lesson)
        {
            this[lessonCount] = lesson;
            lessonCount++;
        }
        public void DersleriYazdir() { for (int i = 0; i < lessonCount; i++) WriteLine("\t Ders: " + lessons[i]); }
        public override string BilgiDondur() { return base.BilgiDondur() + "Ucret: " + Pay; }
    }
}