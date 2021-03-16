using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class factorialnumber
    {
        static void Main(string[] args)
        {
            int num, i, fact = 1;
            Console.WriteLine("Enter the number =");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of given number = " + fact);
            Console.ReadLine();
        }
    }
}
