using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;
using static System.Convert;
namespace ExceptionClass
{
   class UseExcept
    {
        static void Main()
        {
            //Exception Class
            /*
             * Exception birçok özelliği tanımlar.
             * En ilgi çekici üçü Message, StackTrace ve TargetSite'dur.
             * Hepsi salt okunur.
             * Message, hatanın niteliğini açıklayan bir string içeriyor. 
             * StackTrace, exception oluşturan çağrı yığını içeren bir string içerir.
             * TargetSite, özel durumu oluşturan yöntemi belirten bir nesne alır.
             */
            /*
            try { ExcTest.GenException(); }
            catch(IndexOutOfRangeException exc)
            {
                WriteLine("Standard message is: " + exc +
                        "\nStack trace: " + exc.StackTrace + 
                        "\nMessage: " + exc.Message + 
                        "\nTargetSite: " + exc.TargetSite);
            }
            WriteLine("After catch block.");
            */
            int V = 0, F = 0;
            try
            {
                V = Oku("Vize Notu: ");
                F = Oku("Final Notu: ");
            }
            catch(Exception ex) { WriteLine(ex); }
            WriteLine("Vize: " + V + " Final: " + F);
        }
        static int Oku(string str)
        {
            WriteLine(str);
            int V = Int32.Parse(ReadLine());
            if (V > 100 || V < 0) throw new ExamException("Böyle not olmaz ki");
            return V; 
        }
    }
    class ExamException : Exception
    {
        public ExamException(string message) : base(message) { }
        public override string ToString() { return Message; }
    }

    class ExcTest
    {
        //Generate an exception
        public static void GenException()
        {
            int[] nums = new int[4];
            WriteLine("Before exception is generated.");
            //Generate an index out of bounds exception.
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                WriteLine("nums[" + i + "]: " + nums[i]);
            }
            WriteLine("this won't be displayed");
        }
    }
}

