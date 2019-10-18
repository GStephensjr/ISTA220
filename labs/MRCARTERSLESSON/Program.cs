using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRCARTERSLESSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is MRCARTERSLESSON");

            Point point = new Point();
            string mypt = point.ToString();
            Console.WriteLine(mypt);

            Point p2 = new Point();
            mypt = p2.ToString();
            Console.WriteLine(mypt);

            //get the distance between the two points
            double d = point.Distance(p2);
            Console.WriteLine($"The distance between p1 and p2 is {d}");

            //This creates a circle
            Circle circle = new Circle();
            string des = circle.ToString();
            Console.WriteLine(des);
            double area = circle.GetArea();
            double circum = circle.getCircum();
            Console.WriteLine($"The area is {area} and circumference is {circum}");
        }
    }
}
