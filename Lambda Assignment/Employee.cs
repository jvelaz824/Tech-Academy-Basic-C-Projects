using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
   public class Employee
    {
        //Declaring a constructor for the Employee Class
        public Employee(int id, string firstname, string lastname)
        {
            iD = id;
            FirstName = firstname;
            LastName = lastname;
        }

      
        public int iD { get; set; } //Declaring an int property
        public string FirstName { get; set; } //Declaring a string property
        public string LastName { get; set; } //Declaring a string property
    }
}
