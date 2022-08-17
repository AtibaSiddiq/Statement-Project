using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            int largest = 0;
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter the number");
                int number = int.Parse(Console.ReadLine());
                if(i == 0)
                {
                    largest = number;
                }
               else if(number > largest)
               {
                    largest = number;
               }
            }
            Console.WriteLine("The largest number is {0}", largest);
        }
    }
}
