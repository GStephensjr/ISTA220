/***************************************
 * Name: Lab 01a
 * Author: Greg Stephens
 * Date July 3, 2019
 * *************************************/
using System;



namespace TestHello

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello MSSA");
            int numberone = 14;
            int numbertwo = 44;
            int sum = numberone + numbertwo;
            Console.WriteLine("The sum of " + numberone + " and " + numbertwo + " is "
                + sum + ".");
            Console.WriteLine("Enter a number:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter another number:");
            string b = Console.ReadLine();
            Console.WriteLine(a + b);
            numberone = int.Parse(a);
            numbertwo = int.Parse(b);
            sum = numberone + numbertwo;
            Console.WriteLine("int " + numberone + numbertwo);
        }
    }
}
