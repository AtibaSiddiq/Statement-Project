using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any amount to bet on");
            decimal amount = decimal.Parse(Console.ReadLine());
            if(amount < 1 || amount > 1000)
            {
                System.Console.WriteLine("Invalid amount");
            }
        }
    }
}
