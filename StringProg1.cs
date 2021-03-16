using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string");
            string str = Convert.ToString(Console.ReadLine());

            int length = 0;
            foreach(char c in str)
            {
                length = length + 1;
            }
            Console.WriteLine("length of string"+length);
            Console.ReadLine();
        }
    }
}
