using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1  = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int num2  = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int num3  = int.Parse(Console.ReadLine());
            if(num1 < 0 && num2 < 0 || num2 < 0 && num3 < 0 || num3 < 0 && num1 < 0)
            {
                System.Console.WriteLine("+");
            }
            else if(num1 > 0 && num2 > 0 && num3 > 0)
            {
                System.Console.WriteLine("+");
            }
            else if(num1 < 0 && num2 < 0 && num3 < 0)
            {
                System.Console.WriteLine("-");
            }
            else if(num1 < 0 && num2 > 0 || num)
        }
    }
}
