using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    public class MathOperations
    {
        
        //Declare method that takes an integer input and will return an int
        public int MultiplyBy5 (int x)
        {
            int total = x * 5; //multiply the input by 5 and assign the result to an int variable named total
            return total; //return total
        }

        //Declare a method that takes an integer input and will return an int
        //This method is constructed slightly different than above for practice sake
        public int Add50(int x)
        {
            return x + 50; //return the input with 50 added to it
            
        }

        //Declare a method that takes an integer input. but will return a string
        public string OddOrEven(int x)
        {
            int total = x % 2; //int variable will hold the result of x % 2
            string result; //declare a string variable, which will be used for the return
            if (total == 0) //if x % 2 is equal to 0, it is even, so assign a string saying so to 'result'
            {
                result = ("The remainder of " + x + " divided by 2 is: " + total + ", making it even.");
            }
            else //Else, it is odd, so assign a string saying so to 'result'
            {
                result = ("The remainder of " + x + " divided by 2 is: " + total + ", making it odd.");
            }

            return result; //return the result string
        }
    }
}
