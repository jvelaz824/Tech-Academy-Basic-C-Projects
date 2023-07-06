using System;
using System.Collections.Generic;

class Program
{
   static void Main(string[] args)
    {
        //Assignment Part 1

        //Creation of an array of strings
        string[] names = { "Julie", "Erika", "Amanda", "Daniel", "Dawn" };

        //prompting user to input text, and writing the text to a string variable
        Console.Write("Please enter some text to add to the end of some names.");
        string userInput = Console.ReadLine();

        //loop that adds user's text input to the end of each string
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + userInput;
        }

        //loop that prints each string in the array one at a time
        for (int j = 0; j < names.Length; j++)
        {
            Console.WriteLine(names[j]);
        }


        //Assignment Part 2

        //Creating an infinite loop
        int k = 1;

        /* commenting out infinite while loop. Because K will always be less than 7, the loop will not exit and print infinitely
        while(k < 7)
        { 
            Console.writeline("printing infinitely.");
        }
        */

        while(k < 7) 
        {
            Console.WriteLine("Printing with limits.");
            k++; //incrementing k will allow k to reach a point where it is no longer less than 7, thus exiting the loop
        }


        //Assignment Part 3

        //Creating a lop where the comparison used to determine wehteher to continue iterating the loop is "<". The loop will print the message as long as the incrementer is less than the set value
        for(int a = 1; a < 5; a++ )
        {
            Console.WriteLine("Printed " + a + " times");
        }

        //Creating a lop where the comparison used to determine wehteher to continue iterating the loop is "<=". The loop will print the message as long as the incrementer is less than or equal to the set value

        for (int b = 1; b <= 3; b++ )
        {
            Console.WriteLine("Printed this new message " + b + " times");
        }


        //Assignment Part 4

        //intiailizing a list of strings
        List<string> dogNames = new List<string>() { "Spot", "Luna", "Oreo", "Riley", "Max", "Daisy"};

    
        //asks the user to input text, and assigns to a string variable
        Console.Write("I have made a list of dog names. Please enter a name to ssee of it is in the list.");
        string userInput2 = Console.ReadLine();

        int foundAt = -1; //will be used to check if text has been found

        //loop to iterate through list and look for text
        for(int c = 0; c < dogNames.Count; c++)
        {
            if( userInput2 == dogNames[c])
            {
                foundAt = c; //sets foundAt to the index of the found text
                break; //allows the loop to exit early if the input is found
            }
            
        }

        //using a ternary operator to output whether or not the text was found in the list
        string result = foundAt == -1 ? "Your input was not found in the list." : "The input was found at index " + foundAt;
        
        Console.WriteLine(result);



        //Assignment Part 5

        //intiailizing a list of strings
        List<string> schoolSubjects = new List<string>() { "Math", "English", "Science", "History", "Gym", "English"};

        //asks the user to input text, and assigns to a string variable
        Console.Write("I have made a list of school subjects. Please enter a subject to see if it is in the list.");
        string userInput3 = Console.ReadLine();

        List<int> indicesOfMatches = new List<int>(); // list that will store all of the indeces that match the inputted text

        //loop to iterate through list and look for user inputted text
        for (int d = 0; d < schoolSubjects.Count; d++)
        {
            if (userInput3 == schoolSubjects[d])
            {
                indicesOfMatches.Add(d); //if text is found, the index position is added to a new list
            }

        }

        // if else that checks if there is anything in the matches list, if yes, prints the indices, if no, gives the user a not found message
        if(indicesOfMatches.Count > 0)
        {
            Console.WriteLine("Your input was found at index: " + string.Join(", ", indicesOfMatches));
        }
        else
        {
            Console.WriteLine("Your input was not found in the list.");
        }

       


        //Assignment Part 6

        //intiailizing a list of strings with a duplicate
        List<string> movieGenres = new List<string>() { "Action", "Thriller", "Comedy", "Drama", "Romance", "Horror", "Comedy" };

        //creating a second empty list, which will be used to compare the values already passed through on the first list
        List<string> movieGenres2 = new List<string>();

        foreach (string movie in movieGenres)
        {
            if (movieGenres2.Contains(movie)) //checks if the second list has the current item that the loop is on 
            {
                Console.WriteLine(movie + " - This item is a duplicate"); //if it does, displays a duplicate method
            }
            else
            {
                Console.WriteLine(movie + " - This item is unique"); //if it does not, displays a unique message
            }
            movieGenres2.Add(movie); //adds the current item to the second list, so that it can be used to check for duplicates in future iterations
        }



        Console.Read();
    }
    
}
