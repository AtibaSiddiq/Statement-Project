using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 23;
            int num2 = 23;
            int num3 = 23;
            if(num1 > num2 && num1 > num3)
            {
                if(num2 > num3)
                {
                    System.Console.WriteLine($"{num1}, {num2}, {num3}");
                }
                else
                {
                    System.Console.WriteLine($"{num1}, {num3}, {num2}");
                }
            }
            else if(num2 > num1 && num2 > num3)
            {
                if(num1 > num3)
                {
                    System.Console.WriteLine($"{num2}, {num1}, {num3}");
                }
                else
                {
                    System.Console.WriteLine($"{num2}, {num3}, {num1}");
                }
            }
            else if(num3 > num1 && num3 > num2)
            {
                if(num1 > num2)
                {
                    System.Console.WriteLine($"{num3}, {num1}, {num2}");
                }
                else
                {
                    System.Console.WriteLine($"{num3}, {num2}, {num1}");
                }
            }
            else
            {
                System.Console.WriteLine($"{num2}, {num3}, {num1}");
            }
        }
    }
}
