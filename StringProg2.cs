using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg2
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Write a program in C# Sharp to separate the individual characters from a string.");
            string str = "Snehal";
            int l = 0;
            while(l<str.Length)
            {
                Console.WriteLine(str[l]);
                l++;
            }
            Console.ReadLine();
        }
    }
}
