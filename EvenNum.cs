using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class EvenNum
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = new int[5];
            Console.WriteLine("Enter Array Elements :");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter the {0} element-",+i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i]%2==0)
                {
                    count++;
                }
                
            }
            if (count == arr.Length)
            {
                Console.WriteLine("List Of Integers Contains Only Even Number");
            }
            else
            {
                Console.WriteLine("List Of Integers Contains Odd Number");
            }
            Console.ReadLine();

        }
        
        
    }
}
