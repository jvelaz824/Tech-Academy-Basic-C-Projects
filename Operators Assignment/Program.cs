using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating a first object of the 'Employee' class, with properties set           
            Employee emp1 = new Employee() { id = 12345, FirstName = "Jocelyn", LastName = "Velazquez" };

            //instantiating a second object of the 'Employee' class, with properties set 
            Employee emp2 = new Employee() { id = 98765, FirstName = "Dawn", LastName = "Parker" };

            //instantiating a third object of the 'Employee' class, with properties set 
            Employee emp3 = new Employee() { id = 12345, FirstName = "Jocelyn", LastName = "Velaz" };

            bool result1 = emp1 != emp2; //Uses overloaded operator to determine if emp1 is not equal to emp2, stores result in a bool variable
            Console.WriteLine("Are Employee 1 and Employee 2 not equal? "+ result1); //Displays result to the user 

            bool result2 = emp1 == emp3; //Uses overloaded operator to determine if emp1 is equal to emp3, stores result in a bool variable
            Console.WriteLine("Are Employee 1 and Employee 3 equal? " + result2); //Displays result to the user 

            Console.Read();

        }
    }
}
