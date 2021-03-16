using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCsharp
{
    class CallByReference
    {
            public void Show(ref int val)
	        {  
             val *= val;  
	            Console.WriteLine("Value inside the show function "+val);  
	            
	        }  
	         
        static void Main(string[] args)
	        {  
	            int val = 50;
			CallByReference program = new CallByReference(); // Creating Object  
	            Console.WriteLine("Value before calling the function "+val);  
	            program.Show(ref val); // Calling Function by passing reference            
	            Console.WriteLine("Value after calling the function " + val);
			Console.ReadLine();
	        }
}   
}
