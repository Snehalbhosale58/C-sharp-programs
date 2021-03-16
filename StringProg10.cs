using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program in C# Sharp to sort a string array in ascending order.");
            Console.WriteLine("Enter a string=");
            string str = Convert.ToString(Console.ReadLine());
            int l = str.Length;
            char ch;
            char[] arry;
            arry = str.ToCharArray(0, l);
            for(int i=0;i<l;i++)
            {
                for(int j = i+1; j <l; j++)
                {
                    
                    if(arry[i]>arry[j])
                    {
                        ch = arry[j];
                        arry[j] = arry[i];
                        arry[i] = ch;
                        
                    
                    }
                }
            }
            foreach(char c in arry)
            {
                Console.Write("\n{0} ", c);
            }

            Console.ReadLine();
        }

    }
}
