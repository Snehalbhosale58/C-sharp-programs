using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class copy
    {
        int i;
        int j;
       public copy(int a,int b)
        {
            this.i = a;
            this.j = b;
        }

        public copy(copy cpy)
        {
           this.i = cpy.i;
            this.j = cpy.j;
        }
        public string Show4
        {
            get
            {

                return ("\ni:-" + this.i + "\nj " + this.j );
            }

        }
    }
    class Copyconstructor
    {
        static void Main(string[] args)
        {
            copy cp = new copy(10, 20);
            copy c = new copy(cp);
            Console.WriteLine(c.Show4);
            Console.ReadLine();
        }
    }
}
