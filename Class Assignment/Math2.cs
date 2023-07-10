using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class Math2
    {
        // The following is a void method that outputs an integer
        public void division(int x)
        {
            int total = x / 2; //Divides the argument by 2 and assigns the total to an integer variable
            Console.WriteLine("{0} divded by 2 equals: {1}", x, total); //Displays the equation and result to the user
        }

        //The following overloads the division method, this version accepting two parameters
        public void division(int x, int y)
        {
            int total = x / y;
            Console.WriteLine("{0} divided by {1} is equal to: {2}", x, y, total);
        }

        

    }
}
