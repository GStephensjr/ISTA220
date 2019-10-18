using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRCARTERSLESSON
{
    class Point
    {
        int x;
        int y;

        public Point()
        {
            Console.WriteLine("Creating a Point:");
            this.x = getParam("Please enter the X coordinate: ");
            this.y = getParam("Please enter the Y coordinate: ");
        }

        private int getParam(string v)
        {
            Console.Write(v);
            int p = int.Parse(Console.ReadLine());
            return p;
        }
        public override string ToString()
        {
            return $"Point: X={this.x} Y={this.y}";
        }

        public double Distance(Point pt)
        {
            double inner = (Math.Pow(this.x - pt.x, 2) + Math.Pow(this.y - pt.y, 2));
            double distance = Math.Sqrt(inner);
            return distance;
        }
    }
}
