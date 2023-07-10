using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    public abstract class Person //sets the 'Person' class as abstract
    {
        public string firstName { get; set; } //Defines a string property 'firstName'
        public string lastName { get; set; } //Defines a string property 'lastName

        //the following creates a virtual method called 'SayName', which prints the first and last name of an object
        public virtual void SayName()
        {
            Console.WriteLine("Full Name: {0} {1}", firstName, lastName);
        }

    }
}
