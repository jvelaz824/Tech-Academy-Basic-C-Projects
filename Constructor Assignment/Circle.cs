using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Circle
    {
        //Declares two class constructors and chains them together
        public Circle(int Radius, int Diameter)
        {

            diameter = Diameter;
            radius = Radius;
        }

        public Circle(int Radius) : this(Radius, 100)
        {
        }


        public int diameter { get; set; } //Declares a public integer property
        public int radius { get; set; } //Declares a public integer property

    
            

    }
}
