using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Math
    {
        //method that takes an integer and returns an integer
        public int someMath(int x)
        {
            return x * 10; //multiples the integer argument by 10 and returns the result
        }

        //method that takes a decimal and returns an integer
        public int someMath(decimal x)
        {
            return Convert.ToInt32(x) + 37; //converts decimal argument to an int, adds 37, and returns the result
        }

        //method that takes a string and returns an integer
        public int someMath(string x)
        {
            return Convert.ToInt32(x) / 2; //converts string argument to an int, divides it by 2, and returns the result
        }
    }
}
