using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex04
{
    class Horse
    {
        public string name;

        public Horse(String Name)
        {
            name = Name;
        }
        public void Says()
        {
            Console.WriteLine($"Hi I'm {this.name}");
        }
        public void Eats()
        {
            Console.WriteLine("I eat Hay");
        }
        public void Likes()
        {
            Console.WriteLine("I like carrots");
        }
        public void Good()
        {
            Console.WriteLine("I'm good for Horseback riding");
        }
    }
}
