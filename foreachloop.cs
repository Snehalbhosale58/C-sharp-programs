using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class foreachloop
    {
        static void Main(string[] args)
        {
            int[] arry = new int[4] { 1, 2, 3, 4 };
            foreach(int i in arry)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
