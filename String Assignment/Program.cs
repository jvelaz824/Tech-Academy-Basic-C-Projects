using System;
using System.Text;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {   //initializes three strings
            string a = "Cadence";
            string b = "loves";
            string c = "food";

            Console.WriteLine(a + b + c); //concatenates the three strings

            a = a.ToUpper(); //converts string a to uppercase
            Console.WriteLine(a);

            StringBuilder d = new StringBuilder();
            d.Append("Cadence is a pomeranian who loves to eat. ");
            d.Append("Her favorite food is chicken, but she'll eat just about anything. ");
            d.Append("If she could, she would eat all day long. ");
            d.Append("Cadence is a very hungry dog. ");
            d.Append("So we have to be careful and watch what she eats! ");

            Console.WriteLine(d);
            Console.Read();
        }
    }
}
