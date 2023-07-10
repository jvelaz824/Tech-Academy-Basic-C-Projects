using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates an IQuittable/Employee object 'person1' and assigns values to its properties
            IQuittable person1 = new Employee() { firstName = "Jocelyn", lastName = "Velazquez" };

            person1.Quit(); //Calls the method 'Quit' on the 'person1' object

            Console.ReadLine();
        }
    }
}
