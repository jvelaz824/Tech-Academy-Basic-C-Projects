using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates an object of data type Number and sets Amount to 250
            Number num = new Number() { Amount = 250 };
            
            Console.WriteLine(num.Amount); //Displays Amount to user

            Console.Read();


        }
    }
}
