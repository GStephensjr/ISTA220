using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Boat: Vehicle
    {
        public void anchor()
        {
            Console.WriteLine("Dropping anchor");

        }
        public void setSail()
        {
            Console.WriteLine("Setting Sail");
        }
        public override void Drive()
        {
            Console.WriteLine("BoatSlide");
        }

    }
}
