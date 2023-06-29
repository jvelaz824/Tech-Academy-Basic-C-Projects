using System;

class Program
{
    static void Main()
     {
        Console.WriteLine("The Tech Academy \nStudent Daily Report \n"); // prints the two head lines w/ a line break inbetween 
        Console.WriteLine("What is your name? \n"); //prints a line asking the user for their name
        string studentName = Console.ReadLine(); //reads the user's input and assigns to a string variable
        Console.WriteLine("What course are you on? \n"); //prints a line asking the user what course they are on 
        string courseName = Console.ReadLine(); //reads the user's input and assigns to a string variable
        Console.WriteLine("What page number? \n"); //prints a line asking the user what page number they are on 
        string pageNumber = Console.ReadLine(); //reads the user's input and assigns to a string variable
        int currentPageNo = Convert.ToInt32(pageNumber); //converts the string to an integer variable in the event it needs to be used as an integer in future program expansions
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\". \n"); //prints a line asking the user if they need help with anything
        string helpNeeded = Console.ReadLine(); //reads the user's input and assigns to a string variable
        bool helpNeed = Convert.ToBoolean(helpNeeded); // converts the string variable into a boolean
        Console.WriteLine("Is there any positive expierences you'd like to share? Please give specifics. \n"); //prints a line asking the user for their positive experiences
        string positiveExperience = Console.ReadLine(); // reads the user's input and assigns to a string variable
        Console.WriteLine("How many hours did you study today? \n"); //prints a line asking the user how many hours they studied today
        string hoursStudied = Console.ReadLine(); // reads the user's input and assigns to a string variable
        int hrsStudied = Convert.ToInt32(hoursStudied); // convers the string into an integer variable in the event it needs to be used as an integer in future program expansions
        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!"); // prints a msg for the user indicating that an instructor will review the submission shortle
        Console.Read(); // keeps the console open so it can be read 
    }
    
}
