using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex04
{
    class Coyote
    {
        public string name;
        public Coyote(string Name)
        {
            name = Name;
        }
        public void Says()
        {
            Console.WriteLine($"Hi I'm {this.name}");
        }
        public void Eats()
        {
            Console.WriteLine("I eat all of your hard work");
        }
        public void Likes()
        {
            Console.WriteLine("I like chasing hens as fast as their tiny legs can carry them");
        }
        public void Good()
        {
            Console.WriteLine("I do not belong on your farm. I will ruin everything in a single night. Remove me Immediately.");
        }

    }
}
