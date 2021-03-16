using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class primenum
    {
        static void Main(string[] args)
        {
            int i, num;
            
            Console.WriteLine("Enter the number till which you want to print prime number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime Numbers are=");
            for(i=1; i<=num;i++)
            {
                bool isprime = true;
                for (int j=2;j<=Math.Sqrt(i);j++)
                {
                    
                    if (i%j==0)
                    {
                        isprime = false;
                        break;
                    }
                    
                }
                if(isprime)
                {
                    
                    Console.Write("\t{0}", i);
                }
            }

            Console.ReadLine();
        }
    }
}
