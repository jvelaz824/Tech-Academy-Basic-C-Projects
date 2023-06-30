using System;
class Program
{
    static void Main(string[] args)
     {
        Console.WriteLine("Welcome to Package Express. Please follow the insructions below.");

        Console.WriteLine("Please enter the package weight.");
        int pkgWeight = Convert.ToInt32(Console.ReadLine()); //read the user input for package weight, converts it into an integer, and assigns it to an int variable

        //the following evalues if the package weight is greater than 50, and if it is, it outputs an error message and the program ends. If it is not, then it proceeds to ask for more info about the package
        if (pkgWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }

        else
        {
            Console.WriteLine("Please enter the package width:");
            int pkgWidth = Convert.ToInt32(Console.ReadLine()); //read the user input for package width, converts it into an integer, and assigns it to an int variable

            Console.WriteLine("Please enter the package height:");
            int pkgHeight = Convert.ToInt32(Console.ReadLine()); //read the user input for package height, converts it into an integer, and assigns it to an int variable

            Console.WriteLine("Please enter the package length:");
            int pkgLength = Convert.ToInt32(Console.ReadLine()); //read the user input for package length, converts it into an integer, and assigns it to an int variable

            int dimensionsTotalSum = pkgWidth + pkgHeight + pkgLength; //adds the dimensions together and assigns it to an int variable

            // the following nested if block checks if the dimensions summed is greater than 50, if yes, displays an error message, if no, calculates and outputs the shipping quote
            if (dimensionsTotalSum > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else
            {
                double dimensionsTotalMult = pkgHeight * pkgWidth * pkgLength; // calcualtes the dimensions together and saves it as a double to prepare for quote calculation
                double quote = ( dimensionsTotalMult * Convert.ToDouble(pkgWeight)) / 100; //performs the expression to calculate the shipping quote and stores it as a double varible. It is stored as a double in the event that the final division results in a decimal number
                Console.WriteLine("Your estinmated total for shipping this package is: $" + quote + "\nThank you!");
            }
        }

        Console.Read();
        

    }

    
}
