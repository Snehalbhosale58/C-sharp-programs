using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringInterpolation
    {
        static void Main(string[] args)
        {
            string Author = "Snehal Bhosale";
            string hello = $"Hello{Author}";
            Console.WriteLine(hello);
            Console.ReadLine();
        }
    }
}
