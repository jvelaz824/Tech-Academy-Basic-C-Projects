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

        //Declare a method that takes an integer input and will return an int
        public int OddOrEven(int x)
        {
            int total = x % 2; //int variable will hold the result of x % 2
            return total; //return the result string
        }
    }
}
