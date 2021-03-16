using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program in C# Sharp to count the total number of words in a string.");
            string str = "Hello my name is snehal bhosale";

            int wrd = 1;
            int l = 0;
            while(l<str.Length)
            {
                if (str[l]== '\n'|| str[l] == ' ' || str[l] == '\t' ) 
                {
                    wrd++;
                }
                l++;
            }
            Console.WriteLine("Total number of words are :-"+wrd);
            Console.ReadLine();
        }
    }
}
