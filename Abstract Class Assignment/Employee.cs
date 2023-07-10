using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Employee : Person //Inherits from the 'Person' class
    {
        public override void SayName() //Implements the 'SayName' method from the 'Person' class 
        {
            Console.WriteLine("Employee Information: "); //outputs a header line
            base.SayName();
        }
    }
}
