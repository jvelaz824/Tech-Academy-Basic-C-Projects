﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates an Employee object 'person1' and assigns values to its properties
            Employee person1 = new Employee() { firstName = "Sample", lastName = "Student" };

            person1.SayName(); //Calls the superclass method 'SayName' on an employee object

            Console.ReadLine();
        }
    }
}
