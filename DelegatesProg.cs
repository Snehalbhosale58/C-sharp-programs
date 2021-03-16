using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class DelegatesProg
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public void add(int a,int b)
        {
            Console.WriteLine("Addition of numbers is={0}" ,(a+b));
        }
        public void substract(int a ,int b)
        {
            Console.WriteLine("Substraction of numbers is={0}", (a - b));
        }

        static void Main(string[] args)
        {
            DelegatesProg del = new DelegatesProg();
            addnum add = new addnum(del.add);
            subnum sub = new subnum(del.substract);
            add(100, 20);
            sub(200, 20);
            Console.ReadLine();
        }
    }
}
