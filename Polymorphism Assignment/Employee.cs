using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Employee: Person, IQuittable //Employee class inherits from 'Person' class and 'IQuittable' interface
    {

        public override void SayName() //Implements the 'SayName' method from the 'Person' class 
        {
            Console.WriteLine("Employee Information: "); //outputs a header line
            Console.WriteLine("Full Name: {0} {1}", firstName, lastName);
        }

        //The following instantiates the 'Quit' method from the IQuittable interface
        public void Quit() 
        {
            Console.WriteLine(firstName + " " + lastName + " has resigned from the company.");
            Console.WriteLine("Please begin their offboarding process.");
            
        }
    }
}
