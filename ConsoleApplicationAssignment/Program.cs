using System;

 class Program
    {
        static void Main()
        {
        Console.WriteLine("Please enter a number\n");
        string num1 = Console.ReadLine();
        int num1s = Convert.ToInt32(num1);
        int total1 = num1s * 50;
        Console.Write(total1 + "\n");

        Console.WriteLine("Please enter another number\n");
        string num2 = Console.ReadLine();
        int num2s = Convert.ToInt32(num2);
        int total2 = num2s + 25;
        Console.Write(total2 + "\n");

        Console.WriteLine("Please enter another number\n");
        string num3 = Console.ReadLine();
        double num3s = Convert.ToDouble(num3);
        double total3 = num3s / 12.5;
        Console.Write(total3 + "\n");

        Console.WriteLine("Please enter another number\n");
        string num4 = Console.ReadLine();
        int num4s = Convert.ToInt32(num4);
        bool test = num4s > 50;
        Console.Write(test + "\n");

        Console.WriteLine("Please enter another number\n");
        string num5 = Console.ReadLine();
        int num5s = Convert.ToInt32(num5);
        int total5 = num5s % 7;
        Console.Write(total5);

        Console.Read();
        }
    }

