using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class Exceptionhandelling
    {
        static void Main(string[] args)
        {
            try
            {

                int i,j,result;
                Console.WriteLine("Enter the first number =");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the first number =");
                j = Convert.ToInt32(Console.ReadLine());
                result = i / j;
                Console.WriteLine("result is.."+result);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block is executed...");
            }
            Console.ReadLine();
        }
    }
}
