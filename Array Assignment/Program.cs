using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
      
        //intitializes a string array
        string[] namesArray = { "Jocelyn", "Cadence", "Oscar", "Dawn", "Aida" };

        //asks the user to enter a number to display that index of the array
        Console.WriteLine("Enter an a number to display the name at that index of an array.");
        int userInput = Convert.ToInt32(Console.ReadLine());

        bool indexExists = userInput <= 4; //evaluates if the user entered a number that is less than the length of the array

        //the following do/while loop checks if the entered number is less than the length of the array. If it is, then the value at that index number is outputted. If it is larger, than the user is prompted to enter another number until the condition is met.
        do
        {
            if (userInput <= 4)
            {
                Console.WriteLine(namesArray[userInput]);
                break;
            }
            else
            {
                Console.WriteLine("This index does not exist. Please enter another number to try again.");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

        }
        while (!indexExists);

        // initializes an int array
        int[] numArray = {10, 40, 6, 700, 54, 300};

        //asks the user to enter a number to display that index of the array
        Console.WriteLine("Enter an a number to display the number at that index of an array.");
        userInput = Convert.ToInt32(Console.ReadLine());

        indexExists = userInput <= 5;  //evaluates if the user entered a number that is less than the length of the array

        //the following do/while loop checks if the entered number is less than the length of the array. If it is, then the value at that index number is outputted. If it is larger, than the user is prompted to enter another number until the condition is met.
        do
        {
            if (userInput <= 5)
            {
                Console.WriteLine(numArray[userInput]);
                break;
            }
            else
            {
                Console.WriteLine("This index does not exist. Please enter another number to try again.");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

        }
        while (!indexExists);

        //initializes an int list
        List<string> intList = new List<string>();
        intList.Add("Pomeranian");
        intList.Add("Beagle");
        intList.Add("Geate Dane");
        intList.Add("Yorkie");
        intList.Add("Pitbull");
        intList.Add("Husky");

        //asks the user to enter a number to display that index of the list
        Console.WriteLine("Enter an a number to display the dog breed at that index of the list.");
        userInput = Convert.ToInt32(Console.ReadLine());

        indexExists = userInput <= 6;  //evaluates if the user entered a number that is less than the length of the list

        //the following do/while loop checks if the entered number is less than the length of the list. If it is, then the value at that index number is outputted. If it is larger, than the user is prompted to enter another number until the condition is met.
        do
        {
            if (userInput <= 6)
            {
                Console.WriteLine(intList[userInput]);
                break;
            }
            else
            {
                Console.WriteLine("This index does not exist. Please enter another number to try again.");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

        }
        while (!indexExists);




        Console.Read();

    }
    
}
