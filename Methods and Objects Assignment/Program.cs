using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates and initalizs an 'Employee' object 
            Employee test = new Employee() { FirstName = "Sample", LastName = "Student" };

            test.SayName(); //Calls the super class method 'SayName' method on the 'Employee' object

            Console.Read();

        }
    }
}
