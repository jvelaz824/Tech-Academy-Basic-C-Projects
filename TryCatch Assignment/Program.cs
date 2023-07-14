using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {

                Console.WriteLine("Please enter your age."); //asks the user to enter their age
                int age = Convert.ToInt32(Console.ReadLine());


                if (age < 0) //if age is less than 0, throw AgeNegativeException
                {
                    throw new AgeNegativeException();
                }
                else if (age == 0) //if age is equal to 0, throw AgeZeroException
                {
                    throw new AgeZeroException();
                }
                else
                {
                    DateTime currentDate = DateTime.Today;
                    DateTime userYOB = currentDate.AddYears(-age);

                    Console.WriteLine("You were born in: {0}", userYOB.Year);
                    Console.Read();
                }
                    

            }
            catch (AgeNegativeException) //Catch block for for entry that is negative
            {
                Console.WriteLine("Please do not enter a negative number."); //displays an error message to the user
                Console.Read();
                
            }
            catch (AgeZeroException) //Catch block for entry that is 0
            {
                Console.WriteLine("Please enter a number larger than zero."); //displays an error message to the user
                Console.Read();
                
            }
            catch (Exception) //Catch block for all other exceptions
            {
                Console.WriteLine("You have encountered an unknown error. Please contact your system adminstrator."); //displays an error message to the user
                Console.Read();
                return; //terminates program
                
            }


        }   

        
    }
}
