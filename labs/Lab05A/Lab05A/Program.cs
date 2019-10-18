using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.Write("Enter a decimal number to convert to octal: ");
            string input = Console.ReadLine();
            int dec = int.Parse(input);
            Console.WriteLine(dec);
            //Create variables
            int mod = 0;
            int factor = 1;
            int oct = 0;
            //Calculate output
            //Display output
            while (dec > 0)
            {
                mod = dec % 8;
                Console.WriteLine($"Mod is {mod}");
                dec = dec / 8;
                Console.WriteLine($"Dec is {dec}");
                oct += mod * factor;
                Console.WriteLine($"Factor is {factor}");
                Console.WriteLine($"Oct is {oct}");
                factor = factor * 10;

            }
        }
    }
}
