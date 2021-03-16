using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class Palindromenumber
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number=");
            num = Convert.ToInt32(Console.ReadLine());
            int original, reverse=0, remainder = 0;
            original = num;
            while(num!=0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            if(original==reverse)
            {
                Console.WriteLine("Number is palindrome=" + original);

            }
            else
            {
                Console.WriteLine("Number is  not palindrome=" + original);
            }

            Console.ReadLine();
        }

    }
}

