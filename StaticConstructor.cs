using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class staticconstructor
    {
        public static string name = "Snehal";
        static staticconstructor()
            {
            Console.WriteLine("This is static constructor method..");
            }
         static public void display2()
        {
            Console.WriteLine("Entered Name Is =" + name);
        }
    }
    class StaticConstructor
    {
        static void Main(string[] args)
        {
            staticconstructor.display2();
            Console.ReadLine();
        }
    }
}
