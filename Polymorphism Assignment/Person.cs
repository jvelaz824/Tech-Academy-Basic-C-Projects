using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    public abstract class Person
    {
        public string firstName { get; set; } //Defines a string property 'firstName'
        public string lastName { get; set; } //Defines a string property 'lastName

        public abstract void SayName(); //Creates a virtual method called 'SayName'


        
    }
}
