using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class test1
    {
        public void show1()
        {
            Console.WriteLine("This is show1 method...");
        }
    }
    class demo1 : test1
    {
        public void display1()
        {
            Console.WriteLine("This is display1 method...");
        }
    }

    class demo2:demo1
    {
        public void anothermethod()
        {
            Console.WriteLine("This is anothermethod");
        }
    }
    class multilevelinheritance
    {
        static void Main(string[] args)
        {
            demo2 dm = new demo2();
            dm.display1();
            dm.show1();
            dm.anothermethod();
            Console.ReadLine();
        }
    }
}
