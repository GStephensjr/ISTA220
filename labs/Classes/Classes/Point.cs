#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;
        public Point()
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
            Console.WriteLine("Default constructor called");
        }
        private static int objectCount = 0;
        public static int ObjectCount()
        {
            return objectCount;
        }
        
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
            Console.WriteLine($"X:{x}, y:{y}");

        }
        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
    }
}
