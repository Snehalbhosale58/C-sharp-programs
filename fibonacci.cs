using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            int i, j;
            int fnum = 0, nextnum = 1;
            Console.WriteLine("Enter the numbers of fibonacci series you want to show");
            i = Convert.ToInt32(Console.ReadLine());
            int series=0;
            Console.Write("0\t1\t");
            for(j=1;j<=i;j++)
            {
                series = fnum + nextnum;
                fnum = nextnum;
                nextnum = series;
                Console.Write("\t" +series);
            }
           

            Console.ReadLine();
        }
    }
}
