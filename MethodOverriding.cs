using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class Addition
    {
        public virtual void add1(int num1 ,int num2)
        {
            int add = num1 + num2;
            Console.WriteLine("Addition of Numbers=" + add);
        }
    }
    class Add:Addition
    {
        public override void add1(int num1,int num2)
        {
            int add1 = num1 + num2;
            Console.WriteLine("Addition of Numbers=" + add1);
        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            Addition ad = new Add();
            ad.add1(10,20);
            Console.ReadLine();
        }
    }
}
