using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class PatternProg
    {
        static void Main(string[] args)
        {
            int  i, j, k;
            

            for (i = 0; i <= 5; i++)
            {
                k = 1;
                for (j = i; j <= 4; j++)
                    Console.Write(" ");

                for (j = 0; j <= i; j++)
                {
                    Console.Write("{0} ", k);
                    k = (k * (i - j) / (j + 1));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
