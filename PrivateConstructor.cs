using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class demo4
    {
        public static int num = 10;
        private demo4()
        {

        }
    }
    class PrivateConstructor
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Number = " + demo4.num);
            Console.ReadLine();
        }
    }
}
