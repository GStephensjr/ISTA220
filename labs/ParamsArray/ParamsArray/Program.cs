using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(util.Sum(null));
            //Console.WriteLine(util.Sum());
            int total = util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1);

            Console.WriteLine($"The sum of the values is {total}");

        }

        static void Main()
        {
            try
            {

                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
