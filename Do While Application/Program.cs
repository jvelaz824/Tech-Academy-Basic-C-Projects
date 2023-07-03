using System;

namespace Do_While_Application
{
    class Program
    {
        static void Main()
        {
            //The following asks the user to enter a day of the week, and assigns the entry to a string variable
            Console.WriteLine("Enter a day of the week.");
            string day = Console.ReadLine();
            bool isWeekend = false; //initializes the boolean comparison that will be used for the loop

            while (!isWeekend)
            {

                switch (day)  //this switch statement evalutes the user input and goes through a series of cases to decide the output
                {
                    case "Monday":
                        Console.WriteLine("Nope, we don't like Mondays. Enter a different day.");
                        day = Console.ReadLine();
                        break;
                    case "Wednesday":
                        Console.WriteLine("While the Camel may like hump day, we do not. Enter a different day.");
                        day = Console.ReadLine();
                        break;
                    case "Tuesday":
                    case "Thursday":
                        Console.WriteLine("Not a bad day, but could be better. Enter a different day");
                        day = Console.ReadLine();
                        break;
                    case "Friday":
                        Console.WriteLine("We're getting close to a great day. Try again.");
                        day = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Cheers to the weekend!");
                        isWeekend = true;
                        break;

                }

            }


            Console.WriteLine("\nNow let's try with a DO.");

            //the following asks the user to enter a number, converts the entry to an integer value, and assignts it to an integer variable
            Console.WriteLine("Enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isEven = num % 2 == 0;  //initializes the boolean comparison that will be used for the loop. 

            do
            {
                switch (num % 2) //calculates the remainder of the entered number divided by 2
                {
                    case 0: // if there is no remainder, the number is even
                        Console.WriteLine("That is an even number. Good job!");
                        isEven = true;
                        break;
                    default: // since the remainder in this case can only be 0 or 1, the default is used as the other case (where the remainder is 1) and thus the number is odd 
                        Console.WriteLine("That is not an even number. Try again.");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isEven); //keeps going through the above 'do' while isEven is still equal to false
            Console.Read();
        }
    }
}
