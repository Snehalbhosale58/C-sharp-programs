using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class ArryProg4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program to Convert a 2D Array into 1D Array");
            int[,] arry1 = new int[2, 2] {{1,2},{3,4}};
            int[] arry2 = new int[4];
            int k = 0,i,j,l;
            Console.WriteLine("\n 2D Array ;-");
            for( i=0;i<2;i++)
            {
                for ( j = 0; j <2; j++)
                {
                    Console.Write(arry1[i, j]);
                    arry2[k] = arry1[i, j];
                    k++;
                }
                Console.Write("\n " );
            }

            for ( l = 0; l < 4; l++)
            {
                Console.Write("\t" + arry2[l]);
            }
            

            Console.ReadLine();
        }
    }
}
