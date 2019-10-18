using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0;
            double circumference = 0;
            double area = 0;
            Console.WriteLine("Part 1, circumference and area of a circle.");
            Console.Write("Please enter an integer for the radius: ");
            radius = getradius(radius);
            circumference = 2 * Math.PI * radius;
            area = Math.PI * (radius * radius);
            Console.WriteLine($"The Circumference is {circumference}");
            Console.WriteLine($"The Area is {area}");
        }
        private static double getradius(double radius)
        {
            try
            {
                radius = Int32.Parse(Console.ReadLine());
                if (radius < 0)
                {
                    throw new ArgumentException("Input out of range");
                }
                {
                    return radius;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Input out of range");
                Console.Write("Please enter an integer for the radius: ");
                return getradius(radius);
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a valid number");
                Console.Write("Please enter an integer for the radius: ");
                return getradius(radius);
            }
            finally
            {
               // Console.WriteLine("Okay");
            }
        }
    }
}
