using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                Console.WriteLine("Welcome to The Tech Academy. \n");

                var student = new Student();

                Console.WriteLine("Please enter a student's name.");
                student.StudentName = Console.ReadLine();

                Console.WriteLine("What is their date of birth? Please enter as mm/dd/yyy.");
                student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());


                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added to the database. \nThank you! \n");

                Console.WriteLine("Please enter any key to exit.");
                Console.ReadKey();

            }
        }
    }
}
