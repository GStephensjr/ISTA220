using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssbs_ex05
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] alpha = new int[] {0, 2, 4, 6, 8, 10};
            int[] bravo = new int[] { 1, 3, 5, 7, 9 };
            int[] charlie = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            double meanA = getMeanA(alpha);
            double meanB = getMeanB(bravo);
            double meanC = getMeanC(charlie);
            //array element means
            Console.WriteLine($"The average for array A is {meanA}");
            Console.WriteLine($"The average for array B is {meanB}");
            Console.WriteLine($"The average for array C is {meanC}");
            Console.WriteLine("-------------------------------------------------------------------------");
            //reverse array printing
            int[] reverseA = reverseArrayA(alpha);
            Console.Write("The reverse array for A is ");
            Console.WriteLine("[{0}]", string.Join(", ", reverseA));

            int[] reverseB = reverseArrayB(bravo);
            Console.Write("The reverse array for B is ");
            Console.WriteLine("[{0}]", string.Join(", ", reverseB));

            int[] reverseC = reverseArrayC(charlie);
            Console.Write("The reverse array for C is ");
            Console.WriteLine("[{0}]", string.Join(", ", reverseC));
            Console.WriteLine("-------------------------------------------------------------------------"  );
            //array rotations
            Console.Write("enter a direction to rotate the array: ");
            string dir = Console.ReadLine();
            int[] rotarray = getRotArray(dir, alpha, bravo, charlie);
            Console.Write($"rotated array is ");
            Console.Write("[{0}]", string.Join(", ", rotarray));
            Console.WriteLine();
        }

        private static int[] getRotArray(string dir, int[] alpha, int[] bravo, int[] charlie)
        {
            if (dir == "left")
            {
                return getleftrot(alpha, bravo, charlie);
            }
            if (dir == "right")
            {
                return getrightrot(alpha, bravo, charlie);
            }
            else
            {
                throw new FormatException("direction must be left or right");
            }
        }

        private static int[] getrightrot(int[] alpha, int[] bravo, int[] charlie)
        {
            int[] Temp = new int[alpha.Length];
            int len = alpha.Length;
            Console.Write("input number of rotations: ");
            int rotnumber = int.Parse(Console.ReadLine());


            Console.Write("enter the array you want to rotate: ");
            string arrayid = Console.ReadLine();


            if (arrayid == "a")
            {
                int n = 0;
                do
                {
                    for (int curind = 0; curind < len - 1; curind++)
                    {
                        Temp[0] = alpha[alpha.Length - 1];
                        Temp[curind + 1] = alpha[curind];
                    }
                    n++;
                }
                while (n < rotnumber + 1);
                return Temp;
                //int[] arot = rota(alpha, rotnumber);
            }
            else
            {
                throw new FormatException("must choose existing array");
            }
        }

        //private static int[] rota(int[] alpha, int rotnumber)
        //{
        //    int[] resulta;
        //    return null;
        //}

        private static int[] getleftrot(int[] alpha, int[] bravo, int[] charlie)
        {
            int length = alpha.Length;
            int[] Temp = new int[alpha.Length];
            Temp[length - 1] = alpha[0];
            for (int curin = 0; curin < length - 1; curin++)
            {
                Temp[curin] = alpha[curin + 1];
            }
            return Temp;
        }

        private static int[] reverseArrayC(int[] charlie)
        {
            int[] revC = new int[charlie.Length];
            int o = 0;
            for (int i = charlie.Length - 1; i >= 0; i--)
            {
                revC[o] = charlie[i];
                o++;
            }
            return revC;
        }

        private static int[] reverseArrayB(int[] bravo)
        {
            int[] revB = new int[bravo.Length];
            int o = 0;
            for (int i = bravo.Length - 1; i >= 0; i--)
            {
                revB[o] = bravo[i];
                o++;
            }
            return revB;
        }

        private static int[] reverseArrayA(int[] alpha)
        {
            int[] revA = new int[alpha.Length];
            int o = 0;
            for (int i = alpha.Length - 1; i >= 0; i--)
            {
                revA[o] = alpha[i];
                o++;
            }
            return revA;
        }

        private static double getMeanA(int[] alpha)
        {
            double sum = 0;
            for (int i = 0; i < alpha.Length; i++)
            {
                sum += alpha[i];
            }
            double mean = sum / alpha.Length;
            return mean;
        }
        private static double getMeanB(int[] bravo)
        {
            double sum = 0;
            for (int i = 0; i < bravo.Length; i++)
            {
                sum += bravo[i];
            }
            double mean = sum / bravo.Length;
            return mean;
        }
        private static double getMeanC(int[] charlie)
        {
            double sum = 0;
            for (int i = 0; i < charlie.Length; i++)
            {
                sum += charlie[i];
            }
            double mean = sum / charlie.Length;
            return mean;
        }

    }
}
