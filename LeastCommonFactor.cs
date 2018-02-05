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
            CheckNum c = new CheckNum();
            Console.Write("\n Sayi 1:");
            int Num1 = Int32.Parse(Console.ReadLine());
            Console.Write("\n Sayi 2:");
            int Num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n{0} ve {1} sayilarinin en kucuk ortak boleni {2}", Num1, Num2, c.LeastComFactor(Num1, Num2));
        }   
    }

    class CheckNum
    {
        public bool isPrime(int N)
        {
            if (N <= 1) return false;
            for (int i = 2; i < N; i++) if (N % i == 0) return false;

            return true;
        }

        public int LeastComFactor(int N1, int N2)
        {
            if (isPrime(N1) || isPrime(N2)) return 1;
            int Max, LCF = 0;
            if (N1 < N2) Max = N2; else Max = N1;

            for (int i = 2; i < Max; i++) if ((N1 % i == 0) && (N2 % i == 0)) return i;
            return 1;
        }
    }
}
