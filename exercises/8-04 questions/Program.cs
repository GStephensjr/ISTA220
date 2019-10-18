using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_04_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 49, 66, 3, 10, 42, 69, 1, 23, 42 };

            //create an array that sums the even numbers in the array
            sumEvens(a);
            //create a method that sums the numbers divisible by three
            sumThrees(a);
            //count elements ending in a user chosen digit
            countEnds(a);
            int[,] m = { { 1, 2, 3}, { 4, 5, 6}, {7, 8, 9 } };
            transpose(m);
        }

        private static void transpose(int[,] m)
        {
            printMatrix(m);
        }

        private static void printMatrix(int[,] m)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{m[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void countEnds(int[] a)
        {
            Console.Write("Counting ending digits, enter a single integer: ");
            int input = int.Parse(Console.ReadLine());
            int acc = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % input == 0)
                    acc++;
            }
            Console.WriteLine($"There are {acc} numbers ending in {input}");
        }

        private static void sumThrees(int[] a)
        {
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 3 == 0)
                {
                    sum += a[i];
                }

            }
            Console.WriteLine($"sum of the numbers divisible by three is {sum}");
        }

        private static void sumEvens(int[] a)
        {
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] % 2 == 0)
                {
                    sum += a[i];
                }

            }
            Console.WriteLine($"sum of the even numbers is {sum}");

        }
    }
}
