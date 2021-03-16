using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg7
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Write a program in C# Sharp to copy one string to another string.");
            Console.WriteLine("Please Enter String");
            string str1 = Convert.ToString(Console.ReadLine());

            string str2 = "";
            for(int i=0;i<str1.Length;i++)
            {
                str2 = str2+str1[i];
            }

            Console.WriteLine("Copied string is :-"+str2);
            
            Console.ReadLine();
        }
    }
}
