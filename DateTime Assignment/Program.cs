using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now; //saves the current time to a DateTime variable

            Console.WriteLine("The current time is: " + currentTime); //Displays the current time to the user

            Console.WriteLine("Please enter a number."); //Displays a message asking the user to enter a number
            double num = Convert.ToDouble(Console.ReadLine()); //Reads user input, converts it to a double type, and saves it to a variable

            
            DateTime futureTime = currentTime.AddHours(num); //Adds user input as hours to the current time

            Console.WriteLine("In {0} hours it will be: {1}", num, futureTime); //Outputs what time it will be in num hours

           

            Console.Read();
        }
    }
}
