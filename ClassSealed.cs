using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    sealed class EmployeeInfo
    {
        private int id = 3;
       private string name = "Snehal";
        public void show()
        {
            Console.WriteLine("Employee Id Is =" + id);
            Console.WriteLine("Employee Name Is =" +name);
        }
    }
    class ClassSealed
    {
        static void Main(string[] args)
        {
            
            EmployeeInfo info = new EmployeeInfo();
            info.show();
            Console.ReadLine();
        }
    }
}
