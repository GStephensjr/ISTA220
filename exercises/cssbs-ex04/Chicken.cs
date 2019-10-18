using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex04
{
    class Chicken
    {
        public string name;
        public Chicken(string Name)
        {
            name = Name;
        }
        public void Says()
        {
            Console.WriteLine($"Hi I'm {this.name}");
        }
        public void Eats()
        {
            Console.WriteLine("I eat seeds and worms and such");
        }
        public void Likes()
        {
            Console.WriteLine("I like looking vacant literally all the time");
        }
        public void Good()
        {
            Console.WriteLine("I'm good for a deep fried dinner");
        }

    }
}
