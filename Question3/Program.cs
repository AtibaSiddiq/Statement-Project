using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");
            System.Console.WriteLine("Choose the following shapes to help you find its area");
            System.Console.WriteLine("1-Square.\n2-Rectangle.\n3-Triangle.\n4-Circle.\n5-Exit.");
            int option = int.Parse(Console.ReadLine());
            if(option == 1)
            {
                System.Console.WriteLine("Enter the length");
                double length = double.Parse(Console.ReadLine());
                double areaOfSquare = Math.Pow(length, 2);
                System.Console.WriteLine("The area of this square is {0}", areaOfSquare);
            }
            else if(option == 2)
            {
                System.Console.WriteLine("Enter the length");
                double length = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the breadth");
                double breadth = double.Parse(Console.ReadLine());
                double areaOfRectangle = length * breadth;
                System.Console.WriteLine("The area of this rectangle is {0}", areaOfRectangle);
            }
            else if(option == 3)
            {
                System.Console.WriteLine("Enter the base");
                double baze = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the height");
                double height = double.Parse(Console.ReadLine());
                double areaOfTriangle = 0.5 * (baze * height);
                System.Console.WriteLine("The area of this triangle is {0}", areaOfTriangle);
            }
            else if(option == 4)
            {
                System.Console.WriteLine("Enter radius");
                double radius = double.Parse(Console.ReadLine());
                double areaOfCircle = Math.PI * Math.Pow(radius, 2);
                System.Console.WriteLine("The area of this circle is {0}", areaOfCircle);
            }
            else if(option == 5)
            {
                System.Console.WriteLine("Hello User");
            }
            else
            {
                System.Console.WriteLine("Invalid number try again next time");
            }
        }
    }
}
