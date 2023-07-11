using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {

        //the following intializes an enum w/ the days of the week as its values
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {

            try //Try block that will execute the below code
            {
                Console.WriteLine("Please enter the current day of the week."); //displays a message asking the user to enter the current day of the week
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine()); //Takes the user input, parses through DaysOfTheWeek enum for a match, saves the result in the enum variable 'day'


                Console.WriteLine("The current day of the week is: " + currentDay); //Displays message to the user displaying the currentDay if no exceptions are thrown
        }
            
            catch(Exception ex) //Catch statement that will execute if any exceptions are thrown
            {
                Console.WriteLine("Please enter an actual day of the week."); //Displays an error message to the user
            }


            Console.Read();
        }


        
    }
}
