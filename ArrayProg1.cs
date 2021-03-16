using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class ArrayProg1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program in C# Sharp to store elements in an array and print it" +
                ".display it in reverse order.");

            int[] arry = new int[] {1,1,2,3,4,5,6,7,8,9 };

            //foreach(var i in arry)
            //{
            //    Console.Write("\t" + arry[i]);
            //}

            Console.Write("\n Elements of array are:-");
            for (int i=0;i<arry.Length;i++)
            {
               
                Console.Write("\t" + arry[i]);
            }
            Console.Write("\n Reverse Elements of array are:-");
            for (int j=arry.Length-1;j>=0;j--)
            {
                
                Console.Write("\t" + arry[j]);
            }

            Console.ReadLine();
        }
    }
}
