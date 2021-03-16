using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class ArrayProg5
    {
        static void Main(string[] args)
        {
            int[] arry = new int[5] { 1, 4, 6, 4, 3 };
            for(int i=0;i<arry.Length;i++)
            {
                for (int j=i+1; j < arry.Length; j++)
                {
                    if(arry[i]==arry[j])
                    {
                        Console.WriteLine("Duplicate Elements Are :-" + arry[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
