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
            //strDisplay("ali okula gel");
            //strDisplay("ali okula gel",4);
            //strDisplay("ali okula gel",5,8);
            //strDisplay("ali okula gel",-5,8);
            //strDisplay("ali okula gel",-5,28);
            StrReverse("Ali babanin cifligi");
        }

        static void StrReverse(string str)
        {
            if (str.Length > 0) StrReverse(str.Substring(1, str.Length - 1));
            else return;
            Console.Write(str[0]);
        }

        static void strDisplay(string str, int start = 0,int stop = -1)
        {
            if (stop < 0 || stop > str.Length) stop = str.Length;
            if (start < 0 || start > stop) start = 0;

            for (int i = start; i < stop; i++) Console.Write(str[i]);
            Console.WriteLine();
        }
    }
}
