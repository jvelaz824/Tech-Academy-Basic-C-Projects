using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    public class Person
    {
        public string FirstName { get; set; } // a string property that holds a person's First Name
        public string LastName { get; set; }// a string propert that holds a person's Last Name

        //the following is a void method that outputs the first and last name of a 'Person' object
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

    }
}
