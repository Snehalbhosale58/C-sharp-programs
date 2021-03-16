using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class addition
    {
        public void add(int a,int b)
        {
            int m;
            m = a + b;
            Console.WriteLine("Addition Of Numbers ="+m);
        }
        public void add(int a,string name)
        {
            //int n;
           
            //n = a + b;
            Console.WriteLine("Entered Number is =" + a);
            Console.WriteLine("Entered name is" + name);
            
        }
    }
    class MethodOverloading
    {
        static void Main(string[] args)
        {
            addition ad = new addition();
            ad.add(10, 20);
            ad.add(30,"pranjali");
            Console.ReadLine();

        }
    }
}
