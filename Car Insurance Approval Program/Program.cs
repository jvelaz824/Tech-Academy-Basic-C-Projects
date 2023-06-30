using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Car Insurance Approval Program");

        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine()); //reads the user input, converts it to an integer, and asigns it to a integer variable

        Console.WriteLine("Have you ever had a DUI? Please enter true or false.");
        bool DUI = Convert.ToBoolean(Console.ReadLine()); //reads the user input, converts it to a boolean, and assigns it to a boolean variable

        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = Convert.ToInt32(Console.ReadLine()); //reads the user input, converts it to an integer, and assigns it to an integer variable

        bool result = (age > 15 && DUI == false && speedingTickets <= 3); //evaluates the three qualification criterias for applicants and assigns the results to a boolean variable

        Console.WriteLine("Are you qualified for car insurance?");
        Console.WriteLine(result); //outputs the result of the qualification evaluation

        Console.Read();
    }
}
