using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
     class addtn
    {
       public int a;
        public int b;
        public char ch;
       // public addtn()
       //{
       //     a = 25;
       //     b = 75;
       // }

    }
    class defaultconstructor
    {

        static void Main(string[] args)
        {
            addtn adn = new addtn();
            Console.WriteLine(adn.a);
            Console.WriteLine(adn.b);
            Console.WriteLine(adn.ch);
            Console.ReadLine();
        }
    }
}
