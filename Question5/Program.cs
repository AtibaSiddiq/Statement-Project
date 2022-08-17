using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int score = 0;
            if(num >= 1 && num <= 3)
            {
                score = num * 10;
                System.Console.WriteLine("You score is " + score);
            }
            else if(num >= 4 && num <= 6)
            {
                score = num * 100;
                 System.Console.WriteLine("You score is " + score);
            }
            else if(num >= 7 && num <= 9)
            {
                score = num * 1000;
                System.Console.WriteLine("You score is " + score);
            }
            else
            {
                System.Console.WriteLine("Invalid number");
            }
        }
    }
}
