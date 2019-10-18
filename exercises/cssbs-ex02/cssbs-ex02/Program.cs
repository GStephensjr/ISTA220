using System;
using System.Collections.Generic;
using System.Text;
/*
namespace sum2ten
{
    class Program
    /*{
        static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int sum = 0;
            get_sum(start, end, sum);
            char letterGrade;
        }

        private static void get_sum(int start, int end, int sum)
        {
            Console.WriteLine($"get_sum({start}, {end}, {sum})");
            start = start + 1;
            sum = sum + start;
            if (start < end)
                get_sum(start, end, sum);
            else
                Console.WriteLine($"The sum is {sum}");
        }*/
        /*
namespace Grade
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input score for grade: ");
            string Grade = Get_Grade();
            Console.WriteLine("Your Grade is " + Grade);
        }

        private static string Get_Grade()
        {
            string strscore = Console.ReadLine();
            double score = int.Parse(strscore);
            if (score > 89)
                return "A";
            else if (score > 79)
                return "B";
            else if (score > 69)
                return "C";
            else if (score > 59)
                return "D";
            else if (score < 60)
                return "F";
            return null;
        }
    }
}
*/
/*
namespace Average10
{
    class program
    {
        static void Main(string[] args)
        {
            String grade = getgrade();
            Console.WriteLine("Your Letter Grade is " + grade);
        }

        private static string getgrade()
        {
            Console.WriteLine("Enter Grade 1");
            double dbl1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade2");
            double dbl2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade 3");
            double dbl3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade 4");
            double dbl4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade 5");
            double dbl5 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade 6");
            double dbl6 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade 7");
            double dbl7 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade 8");
            double dbl8 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade 9");
            double dbl9 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade 10");
            double dbl10 = Int32.Parse(Console.ReadLine());
            double avg = (dbl1 + dbl2 + dbl3 + dbl4 + dbl5 + dbl6 + dbl7 + dbl8 + dbl9 + dbl10) / 10;
            Console.WriteLine("The Average between these grades is " + avg);
            if (avg > 89)
                return "A";
            else if (avg > 79)
                return "B";
            else if (avg > 69)
                return "C";
            else if (avg > 59)
                return "D";
            else if (avg < 60)
                return "F";
            return null;
        }
    }
}
*//*
namespace SpecificNumberOfTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tests are to be input?");
            double end = Int32.Parse(Console.ReadLine());
            double Start = 1;
            double Sum = 0;
            double dbl1 = 0;

            double dbl3 = 0;
            Console.WriteLine("Input a Grade");
            double Sumroot = Getsum(Start, end, Sum, dbl1, dbl3);
            double avg = Sumroot / end;
            string grade = GetGrade(avg);

            Console.WriteLine("Sumroot = " + Sumroot);
            Console.WriteLine("Your average is " + avg);
            Console.WriteLine("Your Grade is " + grade);

        }

        private static string GetGrade(double avg)
        {
            if (avg > 89)
                return "A";
            else if (avg > 79)
                return "B";
            else if (avg > 69)
                return "C";
            else if (avg > 59)
                return "D";
            else if (avg < 60)
                return "F";
            return null;
        }

        private static double Getsum(double start, double end, double sum, double dbl1, double dbl3)
        {
            double dbl2 = Int32.Parse(Console.ReadLine());
            double dbl4 = dbl1 + dbl2;
            if (start > end - 1)
                return sum + dbl4;
            else
            return Getsum(start + 1, end, sum + dbl4, dbl1, dbl3);
        }
    }
}*/

namespace AverageNonspecificNumberofTests
{
    class Program
    {
        static void Main(string[] args)
        {
            double end = 0;
            double Start = 1;
            double Sum = 0;
            double dbl1 = 0;
            double avg = 0;
            double avgprime = 0;

            double dbl3 = 0;
            Console.WriteLine("Input a Grade");
            double gradeavg = Getsum(Start, end, Sum, dbl1, dbl3, avgprime, avg);
            string grade = GetGrade(gradeavg);

            Console.WriteLine("Your average is " + gradeavg);
            Console.WriteLine("Your Grade is " + grade);

        }

        private static string GetGrade(double avg)
        {
            if (avg > 89)
                return "A";
            else if (avg > 79)
                return "B";
            else if (avg > 69)
                return "C";
            else if (avg > 59)
                return "D";
            else if (avg < 60)
                return "F";
            return null;
        }

        private static double Getsum(double start, double end, double sum, double dbl1, double dbl3, double avg, double avgprime)
        {
            double dbl2 = Int32.Parse(Console.ReadLine());
            double dbl4 = dbl1 + dbl2;
            if (dbl2 < 0)
                return avg;
            else
                end++;
                avg = (dbl4 / end);
                dbl1 = dbl4;
                return Getsum(start + 1, end, sum + dbl4, dbl1, dbl3, avg, avgprime);

        }
    }
}

