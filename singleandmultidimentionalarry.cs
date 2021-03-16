using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class singleandmultidimentionalarry
    {
        static void Main(string[] args)
        {
            string[] arry = new string[] { "Snehal", "Pranjali", "Pari", "Sharada" };
            for (int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }

            string[,] arrry = new string[2, 2] { { "Snehal", "Pari" }, { "Pranjali", "Sharada" } };
            for (int j = 0; j <2; j++)
            {
                for (int k = 0; k<2; k++)
                {
                    Console.Write(arrry[j, k]+"  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
