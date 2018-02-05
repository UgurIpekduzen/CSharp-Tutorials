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
            Min M = new Min();

            Console.WriteLine(M.MinVal());
            Console.WriteLine(M.MinVal(12,20));
            Console.WriteLine(M.MinVal(12,20, -5));

            int[] arguments = { 1, 5, 8, -1, 0, 20 };
            Console.WriteLine(M.MinVal(arguments));
        }
    }

    class Min
    {
        public int MinVal(params int[] Numbers)
        {
            int MinValue;
            if(Numbers.Length == 0)
            {
                Console.WriteLine("No Arguments");
                return 0;
            }
            MinValue = Numbers[0];

            for(int i = 1;i < Numbers.Length; i++)
            {
                if (Numbers[i] < MinValue)
                    MinValue = Numbers[i];
            }
            return MinValue;
        }
    }
}
