using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public static class Math2
    {
        // The following is a void method that outputs an integer
        public static void multiplication(int x)
        {
            int total = x * 2; //Multiplies the argument by 2 and assigns the total to an integer variable
            Console.WriteLine("{0} times 2 equals: {1}", x, total); //Displays the equation and result to the user
        }

        //The following overloads the division method, this version accepting two parameters
        public static void multiplication(int x, int y)
        {
            int total = x * y;
            Console.WriteLine("{0} times {1} is equal to: {2}", x, y, total);
        }

        //The following method contains an output paramater
        public static void outputPrac(int x, out int y)
        {
            y = x * 30; //Multiples the first parameter by 30 and sets that to an integer 'y' which will be outputted

        }


    }
}
