using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
   public class MoreMath
    {
        public static void Math1(int num1, int num2)
        {
            int total = num1 + 50;
            Console.WriteLine("The first number passed ({0}) plus 50 is: {1}", num1, total);
            Console.WriteLine("The second number passed is: " + num2);
        }
    }
}
