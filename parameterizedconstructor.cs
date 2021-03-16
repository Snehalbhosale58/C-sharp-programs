using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class paramter
    {
        int a;
        int b;
        public paramter(int x,int y)
        {
            this.a = x;
            this.b = y;
            Console.WriteLine("First Number is " + a);
            Console.WriteLine("Second Number is " + b);
        }
    }
    class parameterizedconstructor
    {
        static void Main(string[] args)
        {
            int p, q;
            p = 15;
            q = 30;
            
            paramter param = new paramter(p,q);
           

            Console.ReadLine();
        }
    }
}
