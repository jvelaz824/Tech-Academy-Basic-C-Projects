using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations results = new MathOperations(); //instiantiates an object of the Math_operations class

            //Ask user to input a number, converts it to an int, and assigns it to an int variable
            Console.WriteLine("We are going to perform some math operations. \nPlease enter a whole number to test with.");
            int num = Convert.ToInt32(Console.ReadLine());
            

            //calls Add50 method and outputs the result
            Console.WriteLine(num + " + 50 equals: " + results.Add50(num));

            //calls MultiplyBy5 method and outputs the result
            Console.WriteLine(num + " multiplied by 5 equals: " + results.MultiplyBy5(num));

            //calls OddOrEven method and outputs the result
            Console.WriteLine(results.OddOrEven(num));

            Console.Read();
        }

    }
}
