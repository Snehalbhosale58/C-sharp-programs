using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    static class Employee
    {
        public static string name;
        static Employee()
        {
            name = "snehal";
        }
        public static void Details()
        {
            Console.WriteLine("Employee Name :-" + name);

        }
    }
  
    class ClassStatic
    {
        static void Main(string[] args)
        {
            
            Employee.Details();
            Console.ReadLine();
        }
    }
}
