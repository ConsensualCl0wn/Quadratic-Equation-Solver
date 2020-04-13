using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

                // Getting the values from the user
                Console.WriteLine("Please write your first number:");
                double x = Convert.ToInt32(Console.ReadLine());

                // Condition to warn the user
                if (x == 0)
                {
                    Console.Write("The number you have chosen should be above 0. Otherwise, it isn't a quadratic equation");
                    return;
                }

                Console.WriteLine("Please write your second number:");
                double y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please write your last number:");
                double z = Convert.ToInt32(Console.ReadLine());

                if (y * y < 4 * x * z)
                {
                    Console.Write("The equation is a complex one and has no answers");
                    return;
                }

                // First value of the quadratic equation
                c = Math.Sqrt(y * y - 4 * x * z);
                a = (-y + c) / 2 * x;

                // Second value of the quadratic equation
                b = (-y - c) / 2 * x;

                // Another condition to make it look clean
                if (a == b)
                {
                    Console.WriteLine("Both of your values are the same: " + a);
                    return;
                }

                //Printing the results
                //It's WriteLine instead of write so that the second value is printed under the first
                Console.WriteLine("The first value of your equation is: " + a);
                Console.WriteLine("The second value of your equation is " + b);
                Console.ReadLine();
                return;

        }
    }
}
