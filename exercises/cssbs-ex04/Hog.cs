using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex04
{
    class Hog
    {
        public string name;
        public Hog(string Name)
        {
            name = Name;
        }
        public void Says()
        {
            Console.WriteLine($"Hi I'm {this.name}");
        }
        public void Eats()
        {
            Console.WriteLine("I eat almost literally anything");
        }
        public void Likes()
        {
            Console.WriteLine("I like picking fights with any other living soul on the farm");
        }
        public void Good()
        {
            Console.WriteLine("I'm good for Christmas");
        }

    }
}
