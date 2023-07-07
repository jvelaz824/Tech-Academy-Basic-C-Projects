using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    public class MoreMath
    {   
        //Creates a method with one required integer paramater and a second optional integer paramater that has a default of 3 if nothing is passed 
        public int multiply(int x, int y = 3)
        {
            int total = x * y; //Multiplies the two paramaters and assigns the result to an int variable
            return total; //Returns the 'total' variable
        }

    }
}
