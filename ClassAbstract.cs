using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    abstract class Employee1
    {
        public abstract string ename(string name);

    }
    class employee:Employee1
    {
        public override string ename(string name)
        {
            return name;
        }
    }
    class ClassAbstract
    {
        static void Main(string[] args)
        {
            string name = "Snehal";
            employee emp = new employee();
           Console.WriteLine("Employee name is ="+emp.ename(name));
            Console.ReadLine();
        }
    }
}
