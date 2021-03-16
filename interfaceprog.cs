using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    interface oneinterface
    {
        void mymethod();
        
    }
    interface twointerface
    {
        void myanothermethod();
        
    }

    class demo3:oneinterface,twointerface
    {
        public void mymethod()
        {
            Console.WriteLine("This is mymethod...");
        }
        public void myanothermethod()
        {
            Console.WriteLine("This is myanothermethod...");
        }
    }
    class interfaceprog
    {
        static void Main(string[] args)
        {
            demo3 dem = new demo3();
            dem.mymethod();
            dem.myanothermethod();
            Console.ReadLine();
        }
    }
}
