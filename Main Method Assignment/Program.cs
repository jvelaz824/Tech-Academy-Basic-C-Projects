using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Let's perform some math!"); //Displays a start message to the user

            Math equation1 = new Math(); //Instantiates a first object of the Math class
            
            Console.WriteLine("Please enter a whole number to perform a math operation with."); //Asks user to enter a number
            int num1 = Convert.ToInt32(Console.ReadLine()); //Converts user input to an integer and assigns it to a int variable

            int result1 = equation1.someMath(num1); //Calls someMath method, provides an integer argument, and saves the result as an int variable
            Console.WriteLine("{0} * 10 is: {1}", num1, result1); //Displays the equation to the user and provides the result




            Math equation2 = new Math(); //instantiates a second object of the Math class

            Console.WriteLine("Please enter a second whole number to perform a math operation with."); //Asks user to enter a number
            decimal num2 = Convert.ToDecimal(Console.ReadLine()); //Converts user input to a decimal and assigns it to a decimal variable

            int result2 = equation2.someMath(num2); //Calls someMath method, provides a decimal argument, and saves the result as an int variable
            Console.WriteLine("{0} + 37 is: {1}", num2, result2); //Displays the equation to the user and provides the result
          




            Math equation3 = new Math(); //instantiates a third object of the Math class

            Console.WriteLine("Please enter a third whole number to perform a math operation with."); //Asks user to enter a number
            string num3 = Console.ReadLine(); //Assigns user input to a string variable

            int result3 = equation3.someMath(num3); //Calls someMath method, provides a string argument, and saves the result as an int variable
            Console.WriteLine("{0} + 37 is: {1}", num3, result3); //Displays the equation to the user and provides the result
            

            Console.Read();

        }
    }
}
