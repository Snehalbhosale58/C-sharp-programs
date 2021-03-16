using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            dic.Add(1, 2);
            dic.Add(3, 4);
            dic.Add(2, 3);

            foreach(KeyValuePair<int,int> a in dic)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
