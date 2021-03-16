using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class ArryProg2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program in C# Sharp to find the sum of all elements of the array.");
            int[] arry = new int[50];
            Console.WriteLine("Enter the number of elements in array you want =");
           int i= Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int j=0;j<i;j++)
            {
                Console.WriteLine("Enter the {0} element-" + j);
                arry[j] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arry[j];
            }
            
            Console.WriteLine("Sum Of Elements Of Array Are :-"+sum);





            Console.ReadLine();
        }
    }
}
