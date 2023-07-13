using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number."); //Displays a message to the user asking them to enter a number
            int num = Convert.ToInt32(Console.ReadLine()); //Converts user input to an int and saves as an int variable

            //Initiates new StreamWriter and directs to .txt file to add user input to
            using (StreamWriter file = new StreamWriter(@"C:\Users\jocelynv\Documents\InputAssignmentLog.txt", true))
            {
                file.WriteLine(num); //StreamWriter adds value of 'num' to the .txt file
            }

            Console.WriteLine("Numbers in text file: "); //Outputs header line 
            Console.WriteLine(File.ReadAllText(@"C:\Users\jocelynv\Documents\InputAssignmentLog.txt")); //Reads the contents of the .txt file back to the user


            Console.ReadLine(); 

        }
    }
}
