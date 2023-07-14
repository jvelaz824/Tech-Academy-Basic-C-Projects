using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new object of the 'Circle' class - setting 55 to its radius 
            Circle newCircle = new Circle(55);

            //Declares a const double variable that holds the value of pi 
            const double pi = 3.14;

            //Declares a variable using the "var" keyword and assigns the formula for the circumference of a circle to its value
            var circumference = 2 * pi * newCircle.radius;

            //Outputs a starting message to the user
            Console.WriteLine("We created a circle with a radius of {0}. \nLet's calculate its circumference.", newCircle.radius);
       

            //Outputs the circumference of the circle
            Console.WriteLine("The circumference of the circle is: {0}", circumference);

            Console.Read();
        }
    }
}
