using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The math fun continues!"); //displays a start message to the user 

            MoreMath obj1 = new MoreMath(); //instantiates the MoreMathClass

            MoreMath.Math1(78, 5); //Calls the 'Math1' method and passes two integers as arguments

            int x = 15; //creating a intger variable with the value '15'
            int y = 82; //creating an integer variable with the value '82'

            MoreMath.Math1(num1: x, num2: y); //calling the 'Math1' method, specifyng the paramters by name, passing in the two int variables above

            Console.Read();


        }
    }
}
