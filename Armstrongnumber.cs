using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class Armstrongnumber
    {
        static void Main(string[] args)
        {
            int num, original, remainder, reverse = 0;
            int cube, result=0;
            Console.WriteLine("Enter the number=");
            num = Convert.ToInt32(Console.ReadLine());
            original = num;
            while(num!=0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
                cube = remainder * remainder * remainder;
                result = result + cube;

            }
            if(result==original)
            {
                Console.WriteLine("Number is Armstrong=" + original);
            }
            else
            {
                Console.WriteLine("Number is not Armstrong=" + original);
            }
            Console.ReadLine();
        }
    }
}
