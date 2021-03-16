using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program in C# Sharp to print individual characters of the string in reverse order.");
            Console.WriteLine("Please Enter String :-");
            string str = Convert.ToString(Console.ReadLine());
            int l = str.Length-1;
            while(l>=0)
            {
                Console.WriteLine(str[l]);
                l--;
            }
            Console.ReadLine();
        }
    }
}
