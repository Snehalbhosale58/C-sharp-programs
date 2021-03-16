using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class AsynchronusMethod_Await
    {
        async static Task<int> add()
        {
            Task<string> taskurl = new HttpClient().GetStringAsync("http://www.unipune.ac.in");
            string result = await taskurl;
            return result.Length;
        }

        public static void Main(string[] args)

        {
            Task<int> result = add();
            Console.WriteLine("Length is:" + result.Result);
            Console.ReadLine();
        }
    }
}
