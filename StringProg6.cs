using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program in C# Sharp to count a total number of alphabets," +
                " digits and special characters in a string.");
            Console.WriteLine("Please Enter the string =");
            string str = Convert.ToString(Console.ReadLine());

            int i=0, alphabets=0, digits=0, spclchar = 0;
            int l = str.Length;

            while(i<l)
            {
                if((str[i]>='a'&&str[i]<='z')|| (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabets++;
                }
                else if(str[i]>='0'&&str[i]<='9')
                {
                    digits++;
                }
                else
                {
                    spclchar++;
                }
                i++;
            }
            Console.WriteLine("Total number of alphabets ="+alphabets);
            Console.WriteLine("Total number of digits ="+digits);
            Console.WriteLine("Total Number Of spaces and special characters ="+spclchar);
            Console.ReadLine();
        }
    }
}
