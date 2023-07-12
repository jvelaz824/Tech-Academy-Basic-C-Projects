using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Initializing a of type 'Employee'
            List<Employee> Employees = new List<Employee>();

            // Adding 10 employees to the list 
            Employees.Add(new Employee(001, "Joe", "Schmo"));
            Employees.Add(new Employee(002, "Rosa", "Diaz"));
            Employees.Add(new Employee(003, "Amy", "Santiago"));
            Employees.Add(new Employee(004, "Jake", "Peralta"));
            Employees.Add(new Employee(005, "Terry", "Jeffords"));
            Employees.Add(new Employee(006, "Charles", "Boyle"));
            Employees.Add(new Employee(007, "Raymond", "Holt"));
            Employees.Add(new Employee(008, "Gina", "Linetti"));
            Employees.Add(new Employee(009, "Norm", "Scully"));
            Employees.Add(new Employee(010, "Joe", "Row"));
            


            //Initializing an 'Employee' list that will hold employees named 'Joe'
            List<Employee> joeList = new List<Employee>();
            
            //Foreach loop that looks through every employee in the Employees list
            foreach(Employee employee in Employees)
            {
                if(employee.FirstName == "Joe") //If the employee's first name is 'Joe' add them to joeList
                {
                    joeList.Add(employee);
                }
            }

            Console.WriteLine("First List of Employees named \'Joe\' \nID \tFirst Name \tLast Name"); //Print header for list

            //Foreach loop to print out each item in joeList
            foreach(Employee joe in joeList)
            {
                Console.WriteLine(joe.iD + "\t" + joe.FirstName + "\t\t" + joe.LastName);
            }



            //Lambda function that creates a new list and adds all employees with the first name 'Joe' to the list
            List<Employee> joeListLambda = Employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("\nSecond list of Employees named \'Joe\' \nID \tFirst Name \tLast Name"); //Print header for list

            //Foreach loop to print out each item in joeListLambda
            foreach (Employee joe in joeListLambda)
            {
                Console.WriteLine(joe.iD + "\t" + joe.FirstName + "\t\t" + joe.LastName);
            }



            //Lambda function that creates a new list and adds all employees that have an iD greater than 5
            List<Employee> overFive = Employees.Where(x => x.iD > 5).ToList();

            Console.WriteLine("\nEmployees with an ID greater than 5 \nID \tFirst Name \tLast Name"); //Print header for list

            //Foreach loop to print out each item in idCheck list
            foreach (Employee employee in overFive)
            {
                Console.WriteLine(employee.iD + "\t" + employee.FirstName + "\t\t" + employee.LastName);
            }



            Console.Read();
        }

    }
}
