using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class college
    {
        public void teacher()
        {
            Console.WriteLine("This is teacher method..");
        }
    }
    class div1:college
    {
        public void student1()
        {
            Console.WriteLine("This is div1 method..");
        }
    }
    class div2 : college
    {
        public void student2()
        {
            Console.WriteLine("This is div2 method..");
        }
    }
    class hierarchicalinheritance
    {
        static void Main(string[] args)
        {
            div1 d1 = new div1();
            div2 d2 = new div2();
            d1.student1();
            d1.teacher();
            d2.student2();
            d2.teacher();

            Console.ReadLine();
        }
    }
}
