using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");
            System.Console.WriteLine("Choose the following options to performs the task");
            System.Console.WriteLine("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int num2 = int.Parse(Console.ReadLine());
            if(option == 1)
            {
                int sum = num1 + num2;
                System.Console.WriteLine("Your answer is {0}", sum);
            }
            if(option == 2)
            {
                int subtraction = num1 - num2;
                System.Console.WriteLine("Your answer is {0}", subtraction);
            }
            if(option == 3)
            {
                int product = num1 + num2;
                System.Console.WriteLine("Your answer is {0}", product);
            }
            if(option == 4)
            {
                double divide = num1 / num2;
                System.Console.WriteLine("Your answer is {0}", divide);
            }
            if(option == 5)
            {
                System.Console.WriteLine("Hello User");
            }
        }
    }
}
