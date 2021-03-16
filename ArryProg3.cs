using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class ArryProg3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy the elements one array into another array:-");
            int[] arry1 = new int[50];
            int[] arry2 = new int[50];

            Console.WriteLine("Enter the number of elements of array:- ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elements of an array :-");
            for(int i=0;i<num;i++)
            {
                Console.WriteLine("{0} element of array-", +i);
                arry1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                arry2[i] = arry1[i];
            }
            Console.Write("\n Elements of first array are:-");
            for (int i = 0; i < num; i++)
            {

                Console.Write("\t" + arry1[i]);
            }
            Console.Write("\n Elements of second array are:-");
            for (int i = 0; i < num; i++)
            {

                Console.Write("\t" + arry2[i]);
            }
            Console.ReadLine();
        }
    }
}
