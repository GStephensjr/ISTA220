using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int start = 1;
            int end = 10;
            int sum = 0;
            sum = getSum(start, end, sum);
            //Console.WriteLine($"The sum is {sum}");
            //sum of squares from 1 to 10
            sum = 0;
            sum = getSquares(start, end, sum);
            Console.WriteLine($"The sum of the squares is {sum}");
            double sumroot = 0.0;
            sumroot = getRoots(start, end, sumroot);
            Console.WriteLine($"The sum of the roots is {sumroot}");


        }

        private static double getRoots(int start, int end, double sumroot)
        {
            //Console.WriteLine($"The sum of the roots is {sumroot}");
            if (start > end)
                return sumroot;
            else
                return getRoots(start + 1, end, sumroot + Math.Sqrt(start));
        }

        private static int getSquares(int start, int end, int sum)
        {
            //Console.WriteLine($"calling getSum( {start}, {end}, {sum}");
            if (start > end)
                return sum;
            else
                return getSquares(start + 1, end, sum + start * start);
        }

        private static int getSum(int start, int end, int sum)
        {
            //Console.WriteLine($"calling getSum( {start}, {end}, {sum}");
            if (start > end)
                return sum;
            else
                return getSum(start + 1, end, sum + start);
*/
            //calculates factorials
            {
                Console.Write("Please enter a positive integer: ");
                string inputValue = Console.ReadLine();
                int input = int.Parse(inputValue);
                long factorialValue = 1;
                factorialValue = CalculateFactorial(input, factorialValue);
                Console.WriteLine($"Factorial({inputValue}) is {factorialValue}");
            }
        }

        private static long CalculateFactorial(int input, long factorialValue)
        {
            Console.WriteLine($"calling CalculateFactorial({input}, {factorialValue}");
            if (input == 1)
                return factorialValue;
            else
                return CalculateFactorial(input - 1, factorialValue * input);
        }
    }
}
