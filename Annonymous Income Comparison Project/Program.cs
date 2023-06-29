using System;
class Program
{
    static void Main()
     {
        Console.WriteLine("Anonymous Income Comparison Program");

        
        Console.WriteLine("Person 1 \nPlease enter hourly rate."); //Prompts the user to enter the hourly rate for Person 1 
        int hourlyRate1 = Convert.ToInt32(Console.ReadLine()); //Reads user input for the hourly rate and converts the entered string to an int type, which is then saved to an int variable
        Console.WriteLine("Please enter hours worked per week."); //Prompts the user to enter the hours worked for Person 1 
        int hoursWorked1 = Convert.ToInt32(Console.ReadLine()); //Reads user input for the hours worked and converts the entered string to an int type, which is then saved to an int variable


        Console.WriteLine("Person 2 \nPlease enter hourly rate."); //Prompts the user to enter the hourly rate for Person 2
        int hourlyRate2 = Convert.ToInt32(Console.ReadLine()); //Reads user input for the hourly rate and converts the entered string to an int type, which is then saved to an int variable
        Console.WriteLine("Please enter hours worked per week."); //Prompts the user to enter the hours worked for Person 2
        int hoursWorked2 = Convert.ToInt32(Console.ReadLine()); //Reads user input for the hours worked and converts the entered string to an int type, which is then saved to an int variable

        int annualSalary1 = hourlyRate1 * hoursWorked1 * 52; //calculates the yearly wage for Person 1 by multiplying the hourly rate by the number of hours worked by the number of weeks in a year
        Console.WriteLine("Annual Salary of Person 1 is: " + annualSalary1); //ouptuts the annual salary of Person 1

        int annualSalary2 = hourlyRate2 * hoursWorked2 * 52; //calculates the yearly wage for Person 2 by multiplying the hourly rate by the number of hours worked by the number of weeks in a year
        Console.WriteLine("Annual Salary of Person 2 is: " + annualSalary2); //outputs the annual salary of Person2


        Console.WriteLine("Does Person 1 make more money than person 2?");
        bool salaryComparison = annualSalary1 > annualSalary2; //initializes a boolean variable, which compares the salaries of Person 1 & 2, checking if Person 1 makes more than Person 2
        Console.WriteLine(salaryComparison); //Outputs the results of the salaryComparison variable

        Console.Read();

    }
    
}
