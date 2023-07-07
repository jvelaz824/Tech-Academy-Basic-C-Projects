using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some more math!"); //prints a start message to the user

            MoreMath math1 = new MoreMath(); //instantiates the class

            Console.WriteLine("Please enter a first number"); //asks user to enter a first number
            int num1 = Convert.ToInt32(Console.ReadLine()); //converts input to an integer and assigns it to an integer variable

            Console.WriteLine("Please enter a second number, or don't. Whatever floats your boat"); //asks user to enter a second number if they would like to
            string maybe = Console.ReadLine(); //assigns user input to a string variable


            //if/else statement that will evaluate if a second number was entered or not
            if (maybe != "") //if the entered string is not equal to blank
            {
                int num2 = Convert.ToInt32(maybe); //Convert the string to an integer and assign it to an integer variable
                int result = math1.multiply(num1, num2); //Calls the method with both variables, saves the result as an integer variable
                Console.WriteLine("{0} multiplied by {1} equals: {2}", num1, num2, result); //Output the equation and result to the user
            }
            else
            {
                int result2 = math1.multiply(num1); //Calls the method with singular entered variable
                Console.WriteLine("{0} multiplied by 3 equals: {1}", num1, result2); //Output the equation and result to the user
            }



            Console.Read();
        }
    }
}
