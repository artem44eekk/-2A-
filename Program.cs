using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2АтП
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;

            if (x < 1.2)
            {
                y = Math.Log(x);
            }
            else if (x == 1.2)
            {
                y = Math.Cos(x);

            }
            else
            {
                y = 2.7 * Math.Exp(x) + (4 * x) + 56;
            }

            Console.WriteLine($"The value of y: {y}");

            // task 2
            Console.Write("Enter the length of side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("The triangle is equilateral.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("The triangle is isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is scalene.");
                }
            }
            else
            {
                Console.WriteLine("The triangle does not exist.");
            }

            // task 3
            Console.Write("Enter coordinates for point A (x1 y1): ");
            string[] inputA = Console.ReadLine().Split();
            double x1 = Convert.ToDouble(inputA[0]);
            double y1 = Convert.ToDouble(inputA[1]);

            Console.Write("Enter coordinates for point B (x2 y2): ");
            string[] inputB = Console.ReadLine().Split();
            double x2 = Convert.ToDouble(inputB[0]);
            double y2 = Convert.ToDouble(inputB[1]);

            Console.Write("Enter coordinates for point C (x3 y3): ");
            string[] inputC = Console.ReadLine().Split();
            double x3 = Convert.ToDouble(inputC[0]);
            double y3 = Convert.ToDouble(inputC[1]);

            Console.Write("Enter the segment name (AB, BA, AC, CA, BC, CB): ");
            string segment = Console.ReadLine().ToUpper();

            double length = 0;

            switch (segment)
            {
                case "AB":
                    length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                    break;
                case "BA":
                    length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                    break;
                case "AC":
                    length = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                    break;
                case "CA":
                    length = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
                    break;
                case "BC":
                    length = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                    break;
                case "CB":
                    length = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
                    break;
                default:
                    Console.WriteLine("Invalid segment name.");
                    return;
            }

            Console.WriteLine($"The length of segment {segment} is: {length}");
        }
    }
}
