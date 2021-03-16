using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Write a program in C# Sharp to compare two string without using string library functions.");
            Console.WriteLine("Enter the First string");
           string str1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Second string");
            string str2 = Convert.ToString(Console.ReadLine());

            int ctr = 0;
           int l1 = str1.Length;
            int l2 = str2.Length;
            if (l1==l2)
            {
                for(int i=0;i<l1;i++)
                {
                   if( str1[i]==str2[i])
                    {
                        ctr = 1;
                    }
                }
            }
            if ((l1 == l2) && ctr == 1)
            {
                Console.WriteLine("The length of both strings are equal and also, both strings are same");
            }
            else if ((l1 == l2) && ctr == 0)
            {
                Console.WriteLine("The length of both strings are equal but both strings are not same");
            }
            else
            {
                Console.WriteLine("The length of both strings are not equal & both strings are not same");
            }
            Console.ReadLine();
        }
    }
}
