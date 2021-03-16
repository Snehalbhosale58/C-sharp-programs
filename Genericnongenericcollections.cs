using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PracticeCsharp
{
    class Genericnongenericcollections
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----List<>----");
            Console.WriteLine("-------------------------------");
            List<int> lst = new List<int>();
            lst.Add(50);
            lst.Add(13);
            lst.Add(5);
            foreach(var l in lst)
            {
                Console.WriteLine(l);
            }

             Console.WriteLine("-------------------------------");
            Console.WriteLine("-----Dictionary<>----");
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(1,20);
            dic.Add(3,50);
            dic.Add(2, 30);
            foreach(KeyValuePair<int,int>a in dic)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("-----Sorted List<>----");
            SortedList<int, int> s = new SortedList<int, int>();
            s.Add(1, 20);
            s.Add(3, 30);
            s.Add(2, 10);
            foreach(KeyValuePair<int,int> a in s)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-----Stack<>----");
            Stack<string> str = new Stack<string>();
            str.Push("Snehal");
            str.Push("Pranjali");
            str.Push("PAri");
            foreach(var  i in str)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("-----Hashtable----");
            Hashtable ht = new Hashtable();
            ht.Add(1,23);
            ht.Add(3, 25);
            ht.Add(2, 30);

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(" key " + d.Key + " values " + d.Value);
            }

            Console.ReadLine();
        }
    }
}
