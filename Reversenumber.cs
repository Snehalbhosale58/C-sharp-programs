using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class Reversenumber
    {
        static void Main(string[] args)
        {
            int num, remainder, reverse = 0;
            Console.WriteLine("Enter the number =");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
                
            }
            Console.WriteLine("Reverse number is=" + reverse);
            Console.ReadLine();
        }
    }
}
