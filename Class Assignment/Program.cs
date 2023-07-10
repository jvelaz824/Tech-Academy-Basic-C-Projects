using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math2 test = new Math2(); //instantiates object of the 'Math2' class
            Console.WriteLine("Please enter a number."); //prompts the user to enter a number
            int num = Convert.ToInt32(Console.ReadLine()); //converts the user input to integer and assigns it to an integer variable

            test.division(num); //Calls the 'Division Method' and provides an int argument



            Console.WriteLine("Please enter a second number."); //prompts the user to enter a number
            int num2 = Convert.ToInt32(Console.ReadLine()); //converts the user input to integer and assigns it to an integer variable

            test.division(num, num2);


            int num3; //Initializes an int variable that will be used for the output paramater method

            Math1.outputPrac(15, out num3); //Calls the 'outputPrac' method, passing 15, and the result variable through it
            Console.WriteLine("15 times 30 is equal to: " + num3); //Outputs the result variable



            Console.ReadLine();
        }
    }
}
