using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
   static void Main(string[] args)
    {

        
        //initializing a list of integers
        List<int> numbers = new List<int>() { 522, 80, 45, 900, 140, 12 };


        /*    The following will error if a user enters a zero, or non int value
            
        //Asking the user to enter a number tp divide the numbers in the list by
        Console.WriteLine("Please enter a non zero number to divide numbers in a list by");
        int numInput = Convert.ToInt32(Console.ReadLine());

        
        foreach(int num in numbers)
        {
            Console.WriteLine(num / numInput);
        }
        */

        //Asking the user to enter a number tp divide the numbers in the list by
        Console.WriteLine("Please enter a number to divide each number in a list by.");
        int numInput = Convert.ToInt32(Console.ReadLine());

        //initiates try/catch block
        try
        {
            foreach (int num in numbers)
            {
                int result = num / numInput;
                Console.WriteLine(num + " divided by " + numInput + " equals " + result);
            }
        }
        //exception for if user enters 0
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not divide by zero.");
        }
        //exception for if user entetrs a value of the wrong format
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number, not a string.");
        }
        //overall exception for any other errors
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //finally to run after the try catch has completed  
        finally
        {
            Console.WriteLine("The program has executed the try/catch block and finished successfully.");
            Console.Read();
        }
    }
    
}
