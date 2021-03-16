using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program in C# Sharp to find maximum occurring character in a string");
            Console.WriteLine("Please Enter A String =");
            string inputstring = Convert.ToString(Console.ReadLine());
            
            while(inputstring.Length>0)
            {
                int charcount = 0;
                Console.Write(inputstring[0]+"=");
               for(int i=0; i<inputstring.Length;i++)
                {
                    if(inputstring[0]==inputstring[i])
                    {
                        charcount++;
                    }
                }
                Console.WriteLine(charcount);
                inputstring = inputstring.Replace(inputstring[0].ToString(), string.Empty);
            }

            Console.ReadLine();
        }
    }
}
