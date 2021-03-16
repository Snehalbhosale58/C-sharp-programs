using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class swapnumwithoutthirdvariable
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number =");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number =");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Numbers after swapping:\n a={0} \n b={1}", a, b);
            Console.ReadLine();
        }
    }
}
