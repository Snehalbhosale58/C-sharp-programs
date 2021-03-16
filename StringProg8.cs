using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class StringProg8
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Write a program in C# Sharp to count a total number of vowel or consonant in a string.");
            Console.WriteLine("Please Enter The String =");
            string str = Convert.ToString(Console.ReadLine());

            int l = 0;
            int vowelcunt = 0;
            int constcount = 0;
            while(l<str.Length)
            {
                if((str[l]=='a'||str[l]=='A')|| (str[l] == 'e' || str[l] == 'E')||(str[l] == 'i' || str[l] == 'I')||
                        (str[l] == 'o' || str[l] == 'O')||( str[l] == 'u' || str[l] == 'U'))
                {
                    vowelcunt++;
                }
                else /*if((str[l] >= 'a' && str[l] <= 'z') || (str[l] >= 'A' && str[l] <= 'Z'))*/
                {
                    constcount++;
                }
                l++;
            }
            Console.WriteLine("Total numbers of vowels and constant are=" + vowelcunt + "\t" + constcount);
            Console.ReadLine();
        }
    }
}
