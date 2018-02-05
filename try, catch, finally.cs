using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;
using static System.Convert;
namespace ExceptionHandling
{
 
   class ExcDemo
    {
        static void Main()
        {
            //IndexOutOfRangeException catch Örneği
            /**/
            try { ExcTest.GenException(); }
            catch (IndexOutOfRangeException) { WriteLine("Index out of bounds"); }
            WriteLine("After catch block.");
            

            //DivideByZeroException catch Örneği
            /*
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            for(int i = 0;i<numer.Length; i++)
            {
                try { WriteLine(numer[i] + " / " + denom[i] + " = " + numer[i] / denom[i]); }
                catch(DivideByZeroException) { WriteLine("Can't divide by zero!"); }
                //Sıfırla bölünme söz konusu olduğunda ekrana mesajı yazdır ve elemanları döndürmeye devam et.
                catch(IndexOutOfRangeException) { WriteLine("No matching element found"); }
            }
            */

            //"catch all" catch örneği
            //catch komutunda bulunacak Exception girilmezse bütün Exception durumlarını gözden geçirir.
            /*
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            for(int i = 0;i<numer.Length; i++)
            {
                try { WriteLine(numer[i] + " / " + denom[i] + " is " + numer[i] / denom[i]); }
                catch { WriteLine("Some exception occurred"); }
            }
            */

            //Manually throw an exception
            /*
            try
            {
                WriteLine("Before throw.");
                throw new DivideByZeroException();
                //throw la attığımız Exception dan sonra altındaki satırları çalıştırmaz.
                //Bir nevi break gibi çalışır.Döngüde kullandığı zaman o hata dışındaki işlemlere devam eder.
                WriteLine("this won't be displayed");
            }
            catch(DivideByZeroException) { WriteLine("Exception caught."); }
            WriteLine("After try/catch statement.");
            */
            /*
            int[] nums = new int[4];
            int t = 0, what;
            do
            {
                what = ToInt32(ReadLine());
                try
                {
                    switch (what)
                    {
                        case 0: t = 10 / what; break; //sıfıra bölünme hatası üret
                        case 1: nums[4] = 4; break; //indis hatası üret
                        case 2: return;
                    }
                }
                catch (DivideByZeroException)
                {
                    WriteLine("Can't divide by zero!");
                    return;
                }
                catch (IndexOutOfRangeException) { WriteLine("No matching element found."); }
                finally { WriteLine("Leaving try"); }
            } while (what > -1 && what < 3);
        }*/
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

