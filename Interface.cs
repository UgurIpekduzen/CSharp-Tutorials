using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;
using static System.Convert;
namespace Interface
{
    /**/
     class Program
    {
        static void Main(string[] args)
        {
            
            ByTwos t1 = new ByTwos();
            WriteLine(t1.GetNext());
            WriteLine(t1.GetNext());
            t1.Reset();
            t1.SetStart(5);
            WriteLine(t1.GetNext());
            WriteLine(t1.GetPrevious());
            t1.Reset();
            WriteLine(t1.GetPrevious());
            t1.SetStart(9);
            WriteLine(t1.GetPrevious());
        }
    }
    
    /*
    class SeriesDemo2
    {
        //Interface References
        static void Main()
        {
            ByTwos twoOb = new ByTwos();
            Primes primeOb = new Primes();
            ISeries ob;
            for (int i = 0; i < 5; i++)
            {
                ob = twoOb;
                WriteLine("Next ByTwos value is " + ob.GetNext());
                ob = primeOb;
                WriteLine("Next prime number is " + ob.GetNext());
            }
        }
    }
    */
    /*
    class InterfaceIndexerAndProperty
    {
        static void Main()
        {
            Bytwos ob = new Bytwos();
            WriteLine(ob[2]);
        }
    }*/
    public interface ISeries
    {
        /*
            * Interface içine yazılan methodların vücutları olmaz.
            * Interface veri üyelerine sahip olamazlar. 
            * Yapıcıları, yıkıcıları veya operatör yöntemlerini tanımlayamazlar.
            * Bir Interface'de hiçbir üye statik olarak bildirilemez.
            */
        int GetNext();
        void Reset();
        void SetStart(int x);
    }
    //Interface uygulaması
    class ByTwos : ISeries
    {
        int start, val, prev;
        public ByTwos()
        {
            start = 0;
            val = 0;
            prev = -2;
        }
        public int GetNext()
        {
            prev = val;
            val += 2;
            return val;
        }
        public void Reset()
        {
            val = start;
            prev = start - 2;
        }
        public void SetStart(int x)
        {
            start = x;
            val = start;
            prev = val - 2;
        }
        //ISeries harici bir method
        public int GetPrevious() { return prev; }
    }
    class Primes : ISeries
    {
        int start, val;
        public Primes()
        {
            start = 2;
            val = 2;
        }
        public int GetNext()
        {
            bool IsPrime;
            val++;
            for (int i = 0; i < 1000000; i++)
            {
                IsPrime = true;
                for (int j = 2; i <= i / j; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    val = i;
                    break;
                }
            }
            return val;
        }
        public void Reset() { val = start; }
        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }

    //Interface indexers ve properties
    public interface Series
    {
        int Next { get; set; }
        int this[int index] { get; }
    }

    class Bytwos : Series
    {
        int val;
        public Bytwos() { val = 0; }
        public int Next
        {
            get
            {
                val += 2;
                return val;
            }
            set { val = value; }
        }
        public int this[int index]
        {
            get
            {
                val = 0;
                for(int i = 0;i < index; i++) val += 2;
                return val;
            }
        }
    }

    

}

