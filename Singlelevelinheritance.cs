using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class test
    {
        public void show()
        {
            Console.WriteLine("This is show method...");
        }
    }
    class demo : test
    {
        public void display()
        {
            Console.WriteLine("This is display method...");
        }
    }
    class Singlelevelinheritance
    {
        static void Main(string[] args)
        {
            demo dm = new demo();
            dm.display();
            dm.show();
            Console.ReadLine();
        }
    }
}
