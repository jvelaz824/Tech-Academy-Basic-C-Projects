using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Employee
    {
        public int id { get; set; } //Defines int property 'id'
        public string FirstName { get; set; } //Defines string property 'FirstName'
        public string LastName { get; set; } //Defines string propert 'LastName

        public static bool operator== (Employee Employee1, Employee Employee2) //Overrides the '==' operator with two Employee object parameters
        {
            return Employee1.id == Employee2.id; //Checks if two employee 'id' values are equal and returns the result
        }

        public static bool operator!= (Employee Employee1, Employee Employee2) //Overrides the '!=' operator with two Employee object parameters
        {
            return Employee1.id != Employee2.id; //Checks if two employee 'id' values are not equal and returns the result
        }
    }
}
