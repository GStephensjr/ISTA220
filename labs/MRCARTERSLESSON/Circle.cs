using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRCARTERSLESSON
{
    class Circle
    {
        Point center;
        int radius;

        public Circle()
        {
            Console.WriteLine("Creating a circle");
            this.center = getCenter("Please enter a point for center: ");
            this.radius = getRad("Please enter the radius: ");
        }

        public override string ToString()
        {
            return $"Circle: center={this.center}, radius={this.radius}";
        }

        private int getRad(string Prompt)
        {
            Console.Write(Prompt);
            int r = int.Parse(Console.ReadLine());
            return r;
        }

        private Point getCenter(string v)
        {
            Console.Write(v);
            Point c = new Point();
            return c;
        }

        internal double getCircum()
        {
            double c = 2 * Math.PI * this.radius;
            return c;
        }

        internal double GetArea()
        {
            double a = Math.PI * Math.Pow(this.radius, 2);
            return a;
        }
    }
}
